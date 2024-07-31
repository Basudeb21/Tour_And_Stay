using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.LogoutSystem;
using TourStay.UserMenus;
using TourStay.UtilityClass;

namespace TourStay.FormScreens
{
    public partial class UserForm : Form
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private ColorHandler color = new ColorHandler();
        public UserForm()
        {
            InitializeComponent();
            load.changeUC(new ProfileUC(), body_pnl);
            color.setColor(89, 11, 143, Color.White);
            Panel[] pn = { notification_pnl, booking_pnl};
            Label[] lb = { notification_lbl, booking_lbl };
            color.colorChanger(pn, profile_pnl, lb, profile_lbl);
            color.textColorHandler(lb, Color.White, profile_lbl, Color.Black);
        }

        private void cross_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void profile_lbl_Click(object sender, EventArgs e)
        {
            load.changeUC(new ProfileUC(), body_pnl);
            color.setColor(89, 11, 143, Color.White);
            Panel[] pn = { notification_pnl, booking_pnl };
            Label[] lb = { notification_lbl, booking_lbl };
            color.colorChanger(pn, profile_pnl, lb, profile_lbl);
            color.textColorHandler(lb, Color.White, profile_lbl, Color.Black);
        }

        private void notification_lbl_Click(object sender, EventArgs e)
        {
            load.changeUC(new NotificationUC(), body_pnl);
            color.setColor(89, 11, 143, Color.White);
            Panel[] pn = { profile_pnl, booking_pnl };
            Label[] lb = { profile_lbl, booking_lbl };
            color.colorChanger(pn, notification_pnl, lb, notification_lbl);
            color.textColorHandler(lb, Color.White, notification_lbl, Color.Black);
        }

        private void booking_lbl_Click(object sender, EventArgs e)
        {
            load.changeUC(new BookingUC(), body_pnl);
            color.setColor(89, 11, 143, Color.White);
            Panel[] pn = { notification_pnl, profile_pnl };
            Label[] lb = { notification_lbl, profile_lbl };
            color.colorChanger(pn, booking_pnl, lb, booking_lbl);
            color.textColorHandler(lb, Color.White, booking_lbl, Color.Black);
        }

        

        private void profile_img_btn_Click(object sender, EventArgs e)
        {
            profile_lbl_Click(sender, e);
        }

        private void notification_img_btn_Click(object sender, EventArgs e)
        {
            notification_lbl_Click(sender, e);
        }

        private void booking_img_btn_Click(object sender, EventArgs e)
        {
            booking_lbl_Click(sender, e);
        }

        private void logout_lbl_Click(object sender, EventArgs e)
        {
            LogoutForm log = new LogoutForm();
            log.Show();
        }
    }
}
