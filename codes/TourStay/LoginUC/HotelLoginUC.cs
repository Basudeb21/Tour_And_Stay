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

namespace TourStay.LoginUC
{
    public partial class HotelLoginUC : UserControl
    {
        private FormAndUCLoader loader = new FormAndUCLoader();
        private HotelInfoHolder info = new HotelInfoHolder();

        public HotelLoginUC()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            loader.changeUC(new LoginOptionUC(), body_pnl);
        }

        private void mob_no_Click(object sender, EventArgs e)
        {
            hid_inp.Focus();
        }

        private void pass_lbl_Click(object sender, EventArgs e)
        {
            pass_inp.Focus();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            HotelInfoUpdater upd = new HotelInfoUpdater(int.Parse(hid_inp.Text));
            if (upd.isHotel())
            {
                if (info.get_password() == pass_inp.Text)
                {
                    info.set_hid(Int32.Parse(hid_inp.Text));
                    loader.changeForm(this.ParentForm, new HotelForm());

                }
                else
                {
                    MessageBox.Show("You entered wrong password");
                }
            }
            else
            {
                MessageBox.Show("No user found on this  login ID.");
            }


        }
    }
}
