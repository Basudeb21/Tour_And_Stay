using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using TourStay.DBUtilities;
using TourStay.UtilityClass;

namespace TourStay.UserMenus
{
    public partial class UserProfileUpdateForm : UserControl
    {
        private UserLoginInfoHolder info = new UserLoginInfoHolder();
        private GetProfilePic pic = new GetProfilePic();


        public UserProfileUpdateForm()
        {
            InitializeComponent();
            dataLoader();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = ImageToByteArray(profile_pic.Image);
                byte[] ImageToByteArray(Image image)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return ms.ToArray();
                    }
                }
                try
                {
                    ConnectionDB db = new ConnectionDB();
                    SqlConnection con = db.getKey();
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UpdateUserDetails", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@user_name", user_inp.Text); // Assuming u_name, u_mobile, u_email, pass, and img are defined variables
                    cmd.Parameters.AddWithValue("@user_mobile", mob_inp.Text);
                    cmd.Parameters.AddWithValue("@user_email", email_inp.Text);
                    cmd.Parameters.AddWithValue("@user_password", pass_inp.Text);
                    cmd.Parameters.AddWithValue("@user_img", img);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User details updated successfully.");
                        UserInfoUpdater upd = new UserInfoUpdater(mob_inp.Text);
                        upd.isUser();
                        dataLoader();
                    }
                    else
                    {
                        MessageBox.Show("User not found or no changes made.");
                    }

                    con.Close();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            catch(Exception E)
            {

            }

        }

        private void dataLoader()
        {
            user_inp.Text = info.u_nameGet();
            mob_inp.Text = info.u_phnoGet();
            pass_inp.Text = info.u_passwordGet();
            if (info.u_emailGet() != null)
            {
                email_inp.Text = info.u_emailGet();
            }
            if (info.u_imgGet() != null)
            {
                var img = pic.getProfilePic(info.u_phnoGet());
                using (MemoryStream ms = new MemoryStream(img))
                {
                    profile_pic.Image = Image.FromStream(ms);
                }
            }
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    profile_pic.Image = new Bitmap(dialog.FileName);
                    path_inp.Text = dialog.FileName;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }
        }
    }
}
