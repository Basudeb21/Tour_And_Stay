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

namespace TourStay.LoginUC
{
    public partial class LoginOptionUC : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        public LoginOptionUC()
        {
            InitializeComponent();
        }

        private void user_login_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new UserLoginUC(), body_pnl);
        }

        private void hotel_login_link_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelLoginUC(), body_pnl);

        }
    }
}
