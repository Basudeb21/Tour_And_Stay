using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.FormScreens;
using TourStay.UtilityClass;

namespace TourStay.UserMenus
{
    public partial class Card : UserControl
    {
        private TempSpotCard card = new TempSpotCard();
        GetHotelDetailsForUser get;
        public Card()
        {
            InitializeComponent();
            init();
            get = new GetHotelDetailsForUser(ph_lbl.Text);
            get.setDetails();
            get.setComponents();
        }

        private void init()
        {
            ph_lbl.Text = card.get_phno();
            //fair_lbl = 
        }

        private void book_Click(object sender, EventArgs e)
        {
            NotificationForm form = new NotificationForm(2222);
            GetHotelDetails details = new GetHotelDetails(ph_lbl.Text);
            details.getHotelDetails();
            form.Show();
        }

        private void i_btn_Click(object sender, EventArgs e)
        {
            GetHotelDetails details = new GetHotelDetails(ph_lbl.Text);
            details.getHotelDetails();
            NotificationForm form = new NotificationForm(1111);
            form.Show();
        }
    }

   
}
