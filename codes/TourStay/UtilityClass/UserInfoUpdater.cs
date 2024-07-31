using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TourStay.DBUtilities;

namespace TourStay.UtilityClass
{
    internal class UserInfoUpdater
    {
        private UserLoginInfoHolder info = new UserLoginInfoHolder();
        private string phno;
        public UserInfoUpdater(string ph) {
            phno = ph;
        }
        public bool isUser()
        {
            bool sts = false;
            ConnectionDB key = new ConnectionDB();
            SqlConnection cons = key.getKey();
            using (cons)
            {
                using (SqlCommand command = new SqlCommand("GetUserDetailsByMobile", cons))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user_mobile", phno);

                    cons.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                info.u_nameSet(reader.GetString(reader.GetOrdinal("user_name")));
                                info.u_phnoSet(reader.GetString(reader.GetOrdinal("user_mobile")));
                                info.u_passwordSet(reader.GetString(reader.GetOrdinal("user_password")));
                                string mail = reader.GetString(reader.GetOrdinal("user_email"));
                                if (mail != null)
                                {
                                    info.u_emailSet(mail);
                                }
                                else
                                {
                                    info.u_emailSet("Your mail is not registered.");

                                }
                                byte[] img = reader["user_img"]as byte[];
                                if (img != null)
                                {
                                    info.u_imgSet(img);
                                }
                                else
                                {
                                    info.u_imgSet(null);
                                }

                                sts = true;
                            }
                        }
                        return sts;
                    }
                }
            }
        }

    }
}

