using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.DBUtilities;

namespace TourStay.UtilityClass
{
    internal class AddFormDataToHotelDB
    {
        private HotelInfoHolder info = new HotelInfoHolder();
        private HotelFormDataHolder hold = new HotelFormDataHolder();
        private bool flag1 = false;
        private bool flag2 = false;




        public void updateHotelComp(int hid)
        {
            bool flag2 = false;
            try
            {
                ConnectionDB db = new ConnectionDB();
                SqlConnection con = db.getKey();
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateHotelComponents", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hotel_id", info.get_hid());
                cmd.Parameters.AddWithValue("@hotel_ac", hold.get_ac());
                cmd.Parameters.AddWithValue("@hotel_tv", hold.get_tv());
                cmd.Parameters.AddWithValue("@hotel_fridge", hold.get_fridge());
                cmd.Parameters.AddWithValue("@hotel_wifi", hold.get_wifi());
                cmd.Parameters.AddWithValue("@hotel_view", hold.get_view());
                cmd.Parameters.AddWithValue("@hotel_kitchen", hold.get_kitchen());
                cmd.Parameters.AddWithValue("@hotel_dining", hold.get_dining());
                cmd.Parameters.AddWithValue("@hotel_travel", hold.get_travel());
                cmd.Parameters.AddWithValue("@hotel_parking", hold.get_parking());
                cmd.Parameters.AddWithValue("@hotel_food", hold.get_food());



                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    flag2 = true;
                }
                else
                {
                    MessageBox.Show(info.get_hid().ToString());
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error-1: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        public void updateHotelData(int hid)
        {
            
            try
            {
                ConnectionDB db = new ConnectionDB();
                SqlConnection con = db.getKey();
                con.Open();

                SqlCommand cmd = new SqlCommand("UpdateHotelDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@hotel_id", info.get_hid());
                cmd.Parameters.AddWithValue("@hotel_phone", info.get_phno());
                cmd.Parameters.AddWithValue("@hotel_owner", info.get_owner());
                cmd.Parameters.AddWithValue("@hotel_country", info.get_country());
                cmd.Parameters.AddWithValue("@hotel_state", info.get_state());
                cmd.Parameters.AddWithValue("@hotel_spot", info.get_spot());
                cmd.Parameters.AddWithValue("@hotel_pin", info.get_pin());
                cmd.Parameters.AddWithValue("@hotel_pic", info.get_img());
                cmd.Parameters.AddWithValue("@hotel_fair", info.get_fair());


                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    flag1 = true;
                }
                else
                {
                    MessageBox.Show("2");
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("SQL Error-2: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            if (flag1 && flag2) {
                MessageBox.Show("Update Successfully....");
            }

        }
    }
}
