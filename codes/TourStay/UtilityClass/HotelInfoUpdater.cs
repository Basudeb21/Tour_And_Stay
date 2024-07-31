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
    internal class HotelInfoUpdater
    {
        private HotelInfoHolder info = new HotelInfoHolder();
        private HotelFormDataHolder holder = new HotelFormDataHolder();
        private int hid;
        public HotelInfoUpdater(int id)
        {
            hid = id;
        }
        public bool isHotel()
        {
            bool sts = false;
            ConnectionDB key = new ConnectionDB();
            SqlConnection cons = key.getKey();
            using (cons)
            {
                using (SqlCommand command = new SqlCommand("GetHotelDetails", cons))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@hotel_id", hid);

                    cons.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                info.set_hid(reader.GetInt32(reader.GetOrdinal("hotel_id")));
                                info.set_phno(reader.GetString(reader.GetOrdinal("hotel_phone")));
                                info.set_owner(reader.GetString(reader.GetOrdinal("hotel_owner")));
                                info.set_country(reader.GetString(reader.GetOrdinal("hotel_country")));
                                info.set_state(reader.GetString(reader.GetOrdinal("hotel_state")));
                                info.set_spot(reader.GetString(reader.GetOrdinal("hotel_spot")));
                                info.set_pin(reader.GetInt32(reader.GetOrdinal("hotel_pin")));
                                info.set_password(reader.GetString(reader.GetOrdinal("hotel_password")));




                                byte[] img = reader["hotel_pic"] as byte[];
                                if (img != null)
                                {
                                    info.set_img(img);
                                }
                                else
                                {
                                    info.set_img(null);
                                }
                                loadDetails();
                                sts = true;
                            }
                        }
                        return sts;
                    }
                }
            }
        }

        private bool loadDetails()
        {
            bool sts = false;
            ConnectionDB key = new ConnectionDB();
            SqlConnection cons = key.getKey();
            using (cons)
            {
                using (SqlCommand command = new SqlCommand("GetHotelComponents", cons))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@hotel_id", hid);

                    cons.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                holder.set_ac(reader.GetString(reader.GetOrdinal("hotel_ac")));
                                holder.set_tv(reader.GetString(reader.GetOrdinal("hotel_tv")));
                                holder.set_fridge(reader.GetString(reader.GetOrdinal("hotel_fridge")));
                                holder.set_wifi(reader.GetString(reader.GetOrdinal("hotel_wifi")));
                                holder.set_view(reader.GetString(reader.GetOrdinal("hotel_view")));
                                holder.set_kitchen(reader.GetString(reader.GetOrdinal("hotel_kitchen")));
                                holder.set_travel(reader.GetString(reader.GetOrdinal("hotel_travel")));
                                holder.set_parking(reader.GetString(reader.GetOrdinal("hotel_parking")));
                                holder.set_food(reader.GetString(reader.GetOrdinal("hotel_food")));
                                holder.set_dining(reader.GetString(reader.GetOrdinal("hotel_dining")));


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
