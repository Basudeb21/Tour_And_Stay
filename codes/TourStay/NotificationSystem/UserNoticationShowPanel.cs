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

namespace TourStay.NotificationSystem
{
    public partial class UserNoticationShowPanel : UserControl
    {
        private NotificationHolder hold = new NotificationHolder();
        private UserLoginInfoHolder log = new UserLoginInfoHolder();

        public UserNoticationShowPanel()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            NotificationHandler notification = new NotificationHandler();
            notification.hotelConfirmation(log.u_phnoGet());
            msg_lbl.Text = hold.get_facilities();
            sts.Text = hold.get_status();
        }
    }
}
