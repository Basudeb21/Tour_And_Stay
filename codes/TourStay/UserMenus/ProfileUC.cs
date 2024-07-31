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
using TourStay.DBUtilities;
using TourStay.LoginUC;
using TourStay.UtilityClass;

namespace TourStay.UserMenus
{
    public partial class ProfileUC : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private UserLoginInfoHolder info = new UserLoginInfoHolder();
        private ConnectionDB key = new ConnectionDB();
        private GetProfilePic pic = new GetProfilePic();

        public ProfileUC()
        {
            InitializeComponent();
            loadData();
        }

        private void profile_update_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new UserProfileUpdateForm(), body_pnl);
        }
      

        private void loadData()
        {
            user_name_opt.Text = info.u_nameGet();
            user_ph_opt.Text = info.u_phnoGet();
            user_name_opt.Text = info.u_nameGet();
            if(info.u_emailGet() != null)
            {
                user_email_opt.Text = info.u_emailGet();
            }

            Byte[] img = pic.getProfilePic(user_ph_opt.Text);
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream(img))
                {
                    profile_pic.Image = Image.FromStream(ms);
                }

            }
        }


    }
}
