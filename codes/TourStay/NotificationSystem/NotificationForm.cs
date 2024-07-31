using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.NotificationSystem;
using TourStay.UtilityClass;

namespace TourStay.FormScreens
{
    public partial class NotificationForm : Form
    {
        private int sts;
        private FormAndUCLoader load = new FormAndUCLoader();
        public NotificationForm(int sts)
        {
            InitializeComponent();
            this.sts = sts;
            ucLoader();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void ucLoader()
        {
            if(sts == 1111)
            {
                load.changeUC(new OptionsForHotel(), body_pnl);
            }
            else if (sts == 2222)
            {
                load.changeUC(new InfoInterface(), body_pnl);
            }
            else if (sts == 3333)
            {
                load.changeUC(new ShowBookingRequestInfo(), body_pnl);
            }
            else if(sts == 4444)
            {
                load.changeUC(new UserNoticationShowPanel(), body_pnl);
            }
        }
    }
}
