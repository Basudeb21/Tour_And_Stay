using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.UserMenus;
using TourStay.UtilityClass;

namespace TourStay.NotificationSystem
{
    public partial class ShowBookingRequestInfo : UserControl
    {
        NotificationHolder hold = new NotificationHolder();
        public ShowBookingRequestInfo()
        {
            InitializeComponent();
            getNotificationDetails();
        }

       
        public void getNotificationDetails() 
        {
            phno_lbl.Text = hold.get_user_mobile();
            msg_lbl.Text = "Requested facilities by user are :    " + hold.get_facilities();
        }

        private void send_btn_Click(object sender, EventArgs e)
        {  
            NotificationHandler notification = new NotificationHandler();
            bool sts = notification.userConfirmetionNotification(hold.get_user_mobile(), hold.get_hid(), "hotel", select_box.Text , message_inp.Text);
            if(sts)
            {
                select_box.Text = "";
                message_inp.Text = "";
            }
        }
    }
}
