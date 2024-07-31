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
    internal class GetHotelDetailsForUser
    {
        private string phno;
        private HotelInfoHolder hold = new HotelInfoHolder();
        private HotelFormDataHolder info = new HotelFormDataHolder();
        public GetHotelDetailsForUser(string phno)
        {
            this.phno = phno;
        }

        public void setDetails()
        {
            ConnectionDB key = new ConnectionDB();
            SqlConnection cons = key.getKey();
            using (cons)
            {
                using (SqlCommand command = new SqlCommand("GetHotelDetailsByPH", cons))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@hotel_phone", phno);

                    cons.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                hold.set_hid(reader.GetInt32(reader.GetOrdinal("hotel_id")));
                                hold.set_owner(reader.GetString(reader.GetOrdinal("hotel_owner")));
                                hold.set_phno(reader.GetString(reader.GetOrdinal("hotel_phone")));
                                hold.set_country(reader.GetString(reader.GetOrdinal("hotel_country")));
                                hold.set_state(reader.GetString(reader.GetOrdinal("hotel_state")));
                                hold.set_spot(reader.GetString(reader.GetOrdinal("hotel_spot")));
                                hold.set_pin(reader.GetInt32(reader.GetOrdinal("hotel_pin")));
                                hold.set_fair(reader.GetInt32(reader.GetOrdinal("hotel_fair")));
                            }
                        }
                    }
                }
            }
        }

        public void setComponents()
        {
            ConnectionDB key = new ConnectionDB();
            SqlConnection cons = key.getKey();
            using (cons)
            {
                using (SqlCommand command = new SqlCommand("GetHotelComponentsCard", cons))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@hotel_id", hold.get_hid().ToString());

                    cons.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                info.set_ac(reader.GetString(reader.GetOrdinal("hotel_ac")));
                                info.set_tv(reader.GetString(reader.GetOrdinal("hotel_tv")));
                                info.set_fridge(reader.GetString(reader.GetOrdinal("hotel_fridge")));
                                info.set_wifi(reader.GetString(reader.GetOrdinal("hotel_wifi")));
                                info.set_view(reader.GetString(reader.GetOrdinal("hotel_view")));
                                info.set_kitchen(reader.GetString(reader.GetOrdinal("hotel_kitchen")));
                                info.set_dining(reader.GetString(reader.GetOrdinal("hotel_dining")));

                                info.set_travel(reader.GetString(reader.GetOrdinal("hotel_travel")));
                                info.set_parking(reader.GetString(reader.GetOrdinal("hotel_parking")));
                                info.set_food(reader.GetString(reader.GetOrdinal("hotel_food")));

                            }
                        }
                    }
                }
            }
        }

    }
}
