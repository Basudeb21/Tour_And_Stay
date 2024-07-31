using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.DBUtilities;
using TourStay.UtilityClass;

namespace TourStay.HotelMenus
{
    public partial class ProfileUC : UserControl
    {
        private HotelInfoHolder info = new HotelInfoHolder();
        private ConnectionDB key = new ConnectionDB();
        private GetProfilePic pic = new GetProfilePic();
        private HotelFormDataHolder hold = new HotelFormDataHolder();
        public ProfileUC()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            hotel_id_opt.Text = info.get_hid().ToString();
            owner_opt.Text = info.get_owner();
            phone_opt.Text = info.get_phno().ToString();
            country_opt.Text = info.get_country();
            state_opt.Text = info.get_state();
            spot_opt.Text = info.get_spot();
            pin_opt.Text =  info.get_pin().ToString();
            

            Byte[] img = pic.getHotelPic(info.get_hid());
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream(img))
                {
                    hotel_img.Image = Image.FromStream(ms);
                }

            }

            ac_info.Text = hold.get_ac();
            tv_info.Text = hold.get_tv();
            fridge_info.Text = hold.get_fridge();
            wifi_info.Text = hold.get_wifi();
            view_info.Text = hold.get_view();
            kitchen_info.Text = hold.get_kitchen();
            dining_info.Text = hold.get_dining();
            travel_info.Text = hold.get_travel();
            parking_info.Text = hold.get_parking();
            food_info.Text = hold.get_food();
            






        }
    }
}
