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
using System.Xml.Linq;
using TourStay.DBUtilities;
using TourStay.UtilityClass;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TourStay.LoginUC
{
    public partial class UserSignupPage : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        public UserSignupPage()
        {
            InitializeComponent();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            if(this.Parent != null)
            {
                this.ParentForm.WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            load.changeUC(new UserLoginUC(), body_pnl);

        }

        private void username_lbl_Click(object sender, EventArgs e)
        {
            user_inp.Focus();
        }

        private void mob_lbl_Click(object sender, EventArgs e)
        {
            mob_inp.Focus();
        }

        private void pass_lbl_Click(object sender, EventArgs e)
        {
            pass_inp.Focus();
        }

        private void cpass_lbl_Click(object sender, EventArgs e)
        {
            cpass_inp.Focus();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            String u_name = user_inp.Text;
            String mob_no = mob_inp.Text;
            String pass = pass_inp.Text;
            String c_pass = cpass_inp.Text;
            if(pass != c_pass)
            {
                MessageBox.Show("Password and confirm password must be same.....", "Wrong password");
            }
            else
            {
                
                try
                {
                    ConnectionDB db = new ConnectionDB();
                    SqlConnection con = db.getKey();
                    con.Open();

                    SqlCommand cmd = new SqlCommand("InsertUserDetails", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_name", u_name);
                    cmd.Parameters.AddWithValue("@user_password", pass);
                    cmd.Parameters.AddWithValue("@user_mobile", mob_no);

                    int result = cmd.ExecuteNonQuery();
                    if (result == 0)
                    {
                        MessageBox.Show("Registration not successful");
                    }
                    else
                    {
                        MessageBox.Show("Registration successful...");
                        user_inp.Text = "";
                        mob_inp.Text = "";
                        pass_inp.Text = "";
                        cpass_inp.Text = "";
                    }

                    con.Close();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627) // Duplicate primary key error code
                    {
                        MessageBox.Show("Error: Mobile number already exists.");
                        mob_inp.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("SQL Error: " + ex.Message);
                        mob_inp.Text = "";
                    }
                }

            }





        }
    }
}

