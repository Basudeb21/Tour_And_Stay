using System;
using System.Collections;
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
    public partial class InfoInterface : UserControl
    {
        private List<string> facilities_list = new List<string> { };
        private HotelInfoHolderForCard hold = new HotelInfoHolderForCard();
        private UserLoginInfoHolder login = new UserLoginInfoHolder();
        public InfoInterface()
        {
            InitializeComponent();
        }

        private void printData()
        {
            string show = "";
            foreach (var facility in facilities_list)
            {
                show += facility+"  ";
            }
            facilities_selected.Text = show;

        }

        private void send_booking_req_Click(object sender, EventArgs e)
        {
            NotificationHandler notification = new NotificationHandler();
            notification.userBookingRequest(login.u_phnoGet(), hold.get_hid(), "user", "request", facilities_selected.Text);
        }

        private void ac_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ac_chk != null)
            {
                if(ac_chk.Checked && !facilities_list.Contains(ac_chk.Text))
                {
                    facilities_list.Add(ac_chk.Text);
                }
                else
                {
                    facilities_list.Remove(ac_chk.Text);
                }
            }
            printData();
        }

        private void tv_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (tv_chk != null)
            {
                if (tv_chk.Checked && !facilities_list.Contains(tv_chk.Text))
                {
                    facilities_list.Add(tv_chk.Text);
                }
                else
                {
                    facilities_list.Remove(tv_chk.Text);
                }
            }
            printData();
        }

        private void fridge_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (fridge_chk != null)
            {
                if (fridge_chk.Checked && !facilities_list.Contains(fridge_chk.Text))
                {
                    facilities_list.Add(fridge_chk.Text);
                }
                else
                {
                    facilities_list.Remove(fridge_chk.Text);
                }
            }
            printData();
        }

        private void wifi_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (wifi_chk != null)
            {
                if (wifi_chk.Checked && !facilities_list.Contains(wifi_chk.Text))
                {
                    facilities_list.Add(wifi_chk.Text);
                }
                else
                {
                    facilities_list.Remove(wifi_chk.Text);
                }
            }
            printData();
        }

        private void view_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (view_chk != null)
            {
                if (view_chk.Checked && !facilities_list.Contains(view_chk.Text))
                {
                    facilities_list.Add(view_chk.Text);
                }
                else
                {
                    facilities_list.Remove(view_chk.Text);
                }
            }
            printData();
        }

        private void dining_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (dining_chk != null)
            {
                if (dining_chk.Checked && !facilities_list.Contains(dining_chk.Text))
                {
                    facilities_list.Add(dining_chk.Text);
                }
                else
                {
                    facilities_list.Remove(dining_chk.Text);
                }
            }
            printData();
        }

        private void kitchen_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (kitchen_chk != null)
            {
                if (kitchen_chk.Checked && !facilities_list.Contains(kitchen_chk.Text))
                {
                    facilities_list.Add(kitchen_chk.Text);
                }
                else
                {
                    facilities_list.Remove(kitchen_chk.Text);
                }
            }
            printData();
        }

        private void food_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (food_chk != null)
            {
                if (food_chk.Checked && !facilities_list.Contains(food_chk.Text))
                {
                    facilities_list.Add(food_chk.Text);
                }
                else
                {
                    facilities_list.Remove(food_chk.Text);
                }
            }
            printData();
        }

        private void parking_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (parking_chk != null)
            {
                if (parking_chk.Checked && !facilities_list.Contains(parking_chk.Text))
                {
                    facilities_list.Add(parking_chk.Text);
                }
                else
                {
                    facilities_list.Remove(parking_chk.Text);
                }
            }
            printData();
        }

        private void travel_chk_CheckedChanged(object sender, EventArgs e)
        {
            if (travel_chk != null)
            {
                if (travel_chk.Checked && !facilities_list.Contains(travel_chk.Text))
                {
                    facilities_list.Add(travel_chk.Text);
                }
                else
                {
                    facilities_list.Remove(travel_chk.Text);
                }
            }
            printData();
        }
    }
}
