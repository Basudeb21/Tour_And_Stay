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
using TourStay.UtilityClass;

namespace TourStay.UserMenus
{
    public partial class BookingUC : UserControl
    {
        FormAndUCLoader load = new FormAndUCLoader();


        public BookingUC()
        {
            InitializeComponent();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            view_pnl.Controls.Clear();
            string place = search_inp.Text.ToLower();
            ConnectionDB key = new ConnectionDB();
            SqlConnection cons = key.getKey();
            using (cons)
            {
                using (SqlCommand command = new SqlCommand("GetHotelDetailsByPlace", cons))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@hotel_spot", search_inp.Text.ToLower());

                    cons.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                TempSpotCard card = new TempSpotCard();
                                card.set_phno(reader.GetString(reader.GetOrdinal("hotel_phone")));
                                view_pnl.Controls.Add(new Card());
                            }
                        }
                    }
                }
            }
        }
    }
}
