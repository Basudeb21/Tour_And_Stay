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
using TourStay.FormScreens;
using TourStay.UtilityClass;

namespace TourStay.LoginUC
{
    public partial class UserLoginUC : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private UserLoginInfoHolder info = new UserLoginInfoHolder();
        public UserLoginUC()
        {
            InitializeComponent();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            if (this.ParentForm != null)
            {
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

       

        private void mob_no_Click(object sender, EventArgs e)
        {
            mob_inp.Focus();
        }

        private void pass_lbl_Click(object sender, EventArgs e)
        {
            pass_inp.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load.changeUC(new LoginOptionUC(), body_pnl);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new UserSignupPage(), body_pnl);

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
           UserInfoUpdater  upd = new UserInfoUpdater(mob_inp.Text);
            if (upd.isUser())
            {
                if(info.u_passwordGet() == pass_inp.Text)
                {
                    load.changeForm(this.ParentForm, new UserForm());
                }
                else
                {
                    MessageBox.Show("You entered wrong password");
                }
            }
            else
            {
                MessageBox.Show("No user found on this mobile number.");
            }

        }


      


    }
}
