using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.DBUtilities;
using TourStay.UtilittyUC;
using TourStay.UtilityClass;

namespace TourStay.UserMenus
{
    public partial class NotificationUC : UserControl
    {
        private NotificationHolder notification = new NotificationHolder();
        private FormAndUCLoader load = new FormAndUCLoader();
        private UserLoginInfoHolder details = new UserLoginInfoHolder();
        public NotificationUC()
        {
            InitializeComponent();
            notificationLoader();
        }


        private void notificationLoader()
        {
            int count = 0;

            ConnectionDB key = new ConnectionDB();
            SqlConnection cons = key.getKey();
            using (cons)
            {
                using (SqlCommand command = new SqlCommand("GetNotificationsForUser", cons))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@user_mobile", details.u_phnoGet());

                    cons.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            count++;
                            while (reader.Read())
                            {
                                notification.set_user_mobile(reader["user_mobile"].ToString());
                                notification.set_hid(Convert.ToInt32(reader["hotel_id"]));
                                notification.set_message(reader["message"].ToString());
                                notification.set_status(reader["status"].ToString());
                                notification.set_facilities(reader["facilities"].ToString());
                                notify_pnl.Controls.Add(new NotificationBarUC(00000));
                            }
                        }
                    }
                }
            }
        }


    }
}
