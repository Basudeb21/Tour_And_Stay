using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.DBUtilities;

namespace TourStay.UtilityClass
{
    internal class GetProfilePic
    {
        private ConnectionDB key = new ConnectionDB();

        public byte[] getProfilePic(string phno)
        {
            Byte[] profile_pic = null;
            SqlConnection cons = key.getKey();

            using (cons)
            {
                string query = "SELECT user_img FROM user_details_tbl where user_mobile=" + phno;

                SqlCommand cmd = new SqlCommand(query, cons);
                cons.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        profile_pic = reader["user_img"] as Byte[];
                    }
                }
                cons.Close();
            }
            return profile_pic;
        }
        public byte[] getHotelPic(int hid)
        {
            Byte[] profile_pic = null;
            SqlConnection cons = key.getKey();

            using (cons)
            {
                string query = $"SELECT hotel_pic FROM hotel_details_tbl where hotel_id = {hid}";

                SqlCommand cmd = new SqlCommand(query, cons);
                cons.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        profile_pic = reader["hotel_pic"] as Byte[];
                    }
                }
                cons.Close();
            }
            return profile_pic;
        }
    }
}
