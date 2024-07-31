using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.UtilityClass;

namespace TourStay.NotificationSystem
{
    public partial class OptionsForHotel : UserControl
    {
        private HotelInfoHolder info = new HotelInfoHolder();
        private HotelFormDataHolder form = new HotelFormDataHolder();


        public OptionsForHotel()
        {
            InitializeComponent();
            setInfos();
            setDetails();
        }

        private void setInfos()
        {
            phno_lbl.Text = info.get_phno(); 
            owner_lbl.Text = info.get_owner();
            country_lbl.Text = info.get_country();
            state_lbl.Text = info.get_state();
            spot_lbl.Text = info.get_spot();
            pin_lbl.Text = info.get_pin().ToString();
            fair_lbl.Text = info.get_fair().ToString();
        }

        private void setDetails()
        {
            string sts;
            sts = form.get_ac();
            if ( sts == "No" ) 
            {
                ac_sts.ForeColor = Color.Red;
            }
            sts = form.get_fridge();
            if (sts == "No")
            {
                fridge_sts.ForeColor = Color.Red;
            }
            sts = form.get_tv();
            if (sts == "No")
            {
                tv_sts.ForeColor = Color.Red;
            }
            sts = form.get_wifi();
            if (sts == "No")
            {
                wifi_sts.ForeColor = Color.Red;
            }
            sts = form.get_view();
            if (sts == "No")
            {
                view_sts.ForeColor = Color.Red;
            }
            sts = form.get_kitchen();
            if (sts == "No")
            {
                kitchen_sts.ForeColor = Color.Red;
            }
            sts = form.get_dining();
            if (sts == "No")
            {
                dining_sts.ForeColor = Color.Red;
            }
            sts = form.get_travel();
            if (sts == "No")
            {
                travel__sts.ForeColor = Color.Red;
            }
            sts = form.get_food();
            if (sts == "No")
            {
                food_sts.ForeColor = Color.Red;
            }
            sts = form.get_parking();
            if (sts == "No")
            {
                parking_sts.ForeColor = Color.Red;
            }
        }
    }
}
