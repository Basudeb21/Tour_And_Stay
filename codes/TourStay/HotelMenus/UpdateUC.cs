using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.HotelMenus.HotelprofileUC;
using TourStay.LoginUC;
using TourStay.UtilityClass;

namespace TourStay.HotelMenus
{
    public partial class UpdateUC : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();

        public UpdateUC()
        {
            InitializeComponent();
            load.changeUC(new HotelInfoUC(), upd_bg_pnl);
        }
    }
}
