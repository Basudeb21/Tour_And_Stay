using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.HotelMenus;
using TourStay.LogoutSystem;
using TourStay.UtilityClass;

namespace TourStay.FormScreens
{
    public partial class HotelForm : Form
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private ColorHandler color = new ColorHandler();

        public HotelForm()
        {
            InitializeComponent();
            load.changeUC(new ProfileUC(), body_pnl);
            color.setColor(241, 189, 30, Color.White);
            Panel[] pn = { notification_pnl, update_btn_pnl };
            Label[] lb = { notification_lbl, update_lbl };
            color.colorChanger(pn, profile_btn_pnl, lb, profile_lbl);
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
            Panel[] pn = { notification_pnl, update_btn_pnl };
            Label[] lb = {notification_lbl, update_lbl };
            color.colorChanger(pn, profile_btn_pnl, lb, profile_lbl);
        }

        private void update_lbl_Click(object sender, EventArgs e)
        {
            load.changeUC(new UpdateUC(), body_pnl);
            Panel[] pn = { notification_pnl, profile_btn_pnl };
            Label[] lb = { notification_lbl, profile_lbl };
            color.colorChanger(pn, update_btn_pnl, lb, update_lbl);
        }
        

        private void profile_img_btn_Click(object sender, EventArgs e)
        {
            profile_lbl_Click(sender,e);
        }

        private void update_img_btn_Click(object sender, EventArgs e)
        {
            update_lbl_Click(sender, e);
        }

        private void notification_lbl_Click(object sender, EventArgs e)
        {
            load.changeUC(new NotificataionUC(), body_pnl);
            Panel[] pn = { profile_btn_pnl, update_btn_pnl };
            Label[] lb = { profile_lbl, update_lbl };
            color.colorChanger(pn, notification_pnl, lb, notification_lbl);
        }

        private void notification_img_btn_Click(object sender, EventArgs e)
        {
            notification_lbl_Click(sender, e);
        }

       
        private void logout_lbl_Click(object sender, EventArgs e)
        {
            LogoutForm log = new LogoutForm();
            log.Show();
        }
    }
}
