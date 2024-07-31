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

namespace TourStay.UtilittyUC
{
    public partial class NotificationBarUC : UserControl
    {
        private int sts;
        public NotificationBarUC(int sts)
        {
            InitializeComponent();
            this.sts = sts;
        }

        private void i_btn_Click(object sender, EventArgs e)
        {
            if(this.sts == 11111)
            {
                NotificationForm notification = new NotificationForm(3333);
                notification.Show();
                notification_msg.Text = "A new booking request arrived.";
            }
            else if(this.sts == 00000)
            {
                NotificationForm notification = new NotificationForm(4444);
                notification.Show();
                notification_msg.Text = "You got a notification from a hotel.";
            }
            
        }
    }
}
