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
    public partial class HotelComponentsThree : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private HotelFormDetailsHolderKeys hkey = new HotelFormDetailsHolderKeys();
        private HotelFormDataHolder hold = new HotelFormDataHolder();
        private HotelInfoHolder info = new HotelInfoHolder();
        private AddFormDataToHotelDB add = new AddFormDataToHotelDB();

        public HotelComponentsThree()
        {
            InitializeComponent();
            setFormData();
        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelInfoUC(), hotel_comp3_pnl);
            holdFormData();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelComponentsTwo(), hotel_comp3_pnl);
            holdFormData();
        }

        private void holdFormData()
        {
            try
            {
                hkey.setHotelComponentsThree(travel_inp.Text, food_inp.Text, parking_inp.Text);
            }
            catch (Exception e)
            {
                MessageBox.Show("Something went wrong....");
            }

        }
        private void setFormData()
        {
            if (hold.get_travel() != null)
            {
                travel_inp.Text = hold.get_travel();
            }
            if (hold.get_food() != null)
            {
                food_inp.Text = hold.get_food();
            }
            if (hold.get_parking() != null)
            {
                parking_inp.Text = hold.get_parking();
            }
           
        }



        private void submit_form_Click(object sender, EventArgs e)
        {
            holdFormData();
            add.updateHotelData(info.get_hid());
            add.updateHotelComp(info.get_hid());
        }
    }
}
