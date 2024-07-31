using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.HotelMenus.HotelprofileUC;
using TourStay.UtilityClass;

namespace TourStay.HotelMenus.HotelFormUC
{
    public partial class HotelComponentOne : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private HotelFormDetailsHolderKeys hkey = new HotelFormDetailsHolderKeys();
        private HotelFormDataHolder hold = new HotelFormDataHolder();

        public HotelComponentOne()
        {
            InitializeComponent();
            setFormData();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelInfoUC(), hotel_comp1_pnl);
            holdFormData();
        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelComponentsTwo(), hotel_comp1_pnl);
            holdFormData();
        }
        private void holdFormData()
        {
            try
            {
                hkey.setHotelComponentsOne(ac_inp.Text, fridge_inp.Text, wifi_inp.Text, tv_inp.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong....");
            }

        }
        private void setFormData()
        {
            if (hold.get_ac() != null)
            {
                ac_inp.Text = hold.get_ac();
            }
            if (hold.get_fridge() != null)
            {
                fridge_inp.Text = hold.get_fridge();
            }
            if (hold.get_wifi() != null)
            {
                wifi_inp.Text = hold.get_wifi();
            }
            if (hold.get_tv() != null)
            {
                tv_inp.Text = hold.get_tv();
            }
        }



    }
}
