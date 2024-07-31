using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.FormScreens;
using TourStay.LoginUC;
using TourStay.UtilityClass;

namespace TourStay
{
    public partial class SplashScreens : Form
    {
        private FormAndUCLoader fhandler = new FormAndUCLoader();
        public SplashScreens()
        {
            InitializeComponent();
            fhandler.changeUC(new SplashUC(), body_pnl);
            callNextForm();
        }
        private async void callNextForm()
        {
            await Task.Delay(10000);
            fhandler.changeForm(this, new LoginScreen());
        }
    }
}
