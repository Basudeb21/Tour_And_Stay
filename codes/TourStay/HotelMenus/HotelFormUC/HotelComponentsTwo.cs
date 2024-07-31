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
using TourStay.HotelMenus.HotelprofileUC;
using TourStay.UtilityClass;

namespace TourStay.HotelMenus.HotelFormUC
{
    public partial class HotelComponentsTwo : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private HotelFormDetailsHolderKeys hkey = new HotelFormDetailsHolderKeys();
        private HotelFormDataHolder hold = new HotelFormDataHolder();



        public HotelComponentsTwo()
        {
            InitializeComponent();
            setFormData();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelComponentOne(), hotel_comp2_pnl);
            holdFormData();
        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelComponentsThree(), hotel_comp2_pnl);
            MessageBox.Show(view_inp.Text);
            holdFormData();
        }

        private void holdFormData()
        {
            try
            {
                hkey.setHotelComponentsTwo(view_inp.Text, kitchen_inp.Text, dining_inp.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong....");
            }

        }
        private void setFormData()
        {
            if (hold.get_view() != null)
            {
                view_inp.Text = hold.get_view();
            }
            if (hold.get_kitchen() != null)
            {
                kitchen_inp.Text = hold.get_kitchen();
            }
            if (hold.get_dining() != null)
            {
                dining_inp.Text = hold.get_dining();
            }
        }
    }
}
