using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TourStay.DBUtilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TourStay.UtilityClass
{
    internal class NotificationHandler
    {
        public void userBookingRequest(string u_mob, int h_id, string message, string status, string facilities)
        {
            try
            {
                ConnectionDB db = new ConnectionDB();
                using (SqlConnection con = db.getKey())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertNotification", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_mobile", u_mob);
                        cmd.Parameters.AddWithValue("@hotel_id", h_id);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@facilities", facilities);

                        int result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Request not sent");
                        }
                        else
                        {
                            MessageBox.Show("Request sent...");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        public void hotelConfirmation(string mob)
        {
            NotificationHolder notification = new NotificationHolder();
            try
            {
                ConnectionDB db = new ConnectionDB();
                using (SqlConnection con = db.getKey())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("GetNotificationsForUser", con))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_mobile", mob);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                notification.set_user_mobile(reader["user_mobile"].ToString());
                                notification.set_hid(Convert.ToInt32(reader["hotel_id"]));
                                notification.set_message(reader["message"].ToString());
                                notification.set_status(reader["status"].ToString());
                                notification.set_facilities(reader["facilities"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        public bool userConfirmetionNotification(string u_mob, int h_id, string message, string status, string facilities) 
        {
            bool sts = false;
            try
            {
                ConnectionDB db = new ConnectionDB();
                using (SqlConnection con = db.getKey())
                {
                    con.Open();

                    using (SqlCommand cmd = new SqlCommand("InsertNotification", con))
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@user_mobile", u_mob);
                        cmd.Parameters.AddWithValue("@hotel_id", h_id);
                        cmd.Parameters.AddWithValue("@message", message);
                        cmd.Parameters.AddWithValue("@status", status);
                        cmd.Parameters.AddWithValue("@facilities", facilities);

                        int result = cmd.ExecuteNonQuery();
                        if (result == 0)
                        {
                            MessageBox.Show("Request not sent");
                        }
                        else
                        {
                            MessageBox.Show("Request sent...");
                            sts = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            return sts;
        }
    }
}
