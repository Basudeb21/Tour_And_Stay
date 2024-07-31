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

namespace TourStay.LogoutSystem
{
    public partial class LogoutForm : Form
    {
        FormAndUCLoader load = new FormAndUCLoader();
        public LogoutForm()
        {
            InitializeComponent();
        }

        private void yes_btn_Click(object sender, EventArgs e)
        {
            load.changeForm(this, new LoginScreen());
            load.closeAllForm();
            removeHotelComps();
            removeHotelDetails();
            removeNotification();
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void removeNotification()
        {
            NotificationHolder hold = new NotificationHolder();
            hold.set_hid(00000);
            hold.set_facilities(null);
            hold.set_message(null);
            hold.set_status(null);
            hold.set_user_mobile(null);
        }
        private void removeHotelComps()
        {
            HotelFormDataHolder hold = new HotelFormDataHolder();
            hold.set_ac("");
            hold.set_dining("");
            hold.set_food("");
            hold.set_fridge("");
            hold.set_kitchen("");
            hold.set_parking("");
            hold.set_travel("");
            hold.set_tv("");
            hold.set_view("");
            hold.set_wifi("");
        }

        private void removeHotelDetails()
        {
            HotelInfoHolder hold = new HotelInfoHolder();
            hold.set_hid(0000);
            hold.set_pin(0000);
            hold.set_fair(0000);
            hold.set_country("");
            hold.set_img(null);
            hold.set_owner("");
            hold.set_password(null);
            hold.set_phno(null);
            hold.set_spot(null);
            hold.set_state(null);
        }
    }
}
