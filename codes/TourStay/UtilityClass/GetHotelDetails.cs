using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.DBUtilities;
using System.Security.Cryptography;

namespace TourStay.UtilityClass
{
    internal class GetHotelDetails
    {
        private HotelInfoHolder info = new HotelInfoHolder();
        private HotelInfoHolderForCard hold = new HotelInfoHolderForCard();
       
        private string ph;
        public GetHotelDetails(string ph)
        {
            this.ph = ph;
        }


        public void getHotelDetails()
        {
           
                ConnectionDB key = new ConnectionDB();
                SqlConnection cons = key.getKey();
                using (cons)
                {
                    using (SqlCommand command = new SqlCommand("GetHotelDetailsByPhone", cons))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@hotel_phone", ph);

                        cons.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    info.set_hid(reader.GetInt32(reader.GetOrdinal("hotel_id")));
                                    info.set_owner(reader.GetString(reader.GetOrdinal("hotel_owner")));
                                    info.set_phno(reader.GetString(reader.GetOrdinal("hotel_phone")));
                                    info.set_country(reader.GetString(reader.GetOrdinal("hotel_country")));
                                    info.set_state(reader.GetString(reader.GetOrdinal("hotel_state")));
                                    info.set_spot(reader.GetString(reader.GetOrdinal("hotel_spot")));
                                    info.set_pin(reader.GetInt32(reader.GetOrdinal("hotel_pin")));
                                    info.set_fair(reader.GetInt32(reader.GetOrdinal("hotel_fair")));
                                    hold.set_hid(reader.GetInt32(reader.GetOrdinal("hotel_id")));
                                    MessageBox.Show(hold.get_hid().ToString());
                                }
                            }
                        }
                    }
                }

        }

      
    }
}
