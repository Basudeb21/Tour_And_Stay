using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.HotelMenus.HotelFormUC;
using TourStay.UtilityClass;

namespace TourStay.HotelMenus.HotelprofileUC
{
    public partial class HotelInfoUC : UserControl
    {
        private FormAndUCLoader load = new FormAndUCLoader();
        private HotelFormDetailsHolderKeys hkey = new HotelFormDetailsHolderKeys();
        private HotelInfoHolder hold = new HotelInfoHolder();
        private GetProfilePic pic = new GetProfilePic();



        public HotelInfoUC()
        {
            InitializeComponent();
            setFormData();
        }

        private void nxt_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelComponentOne(), hotel_info_pnl);
            holdFormData();
        }

        private void prev_btn_Click(object sender, EventArgs e)
        {
            load.changeUC(new HotelComponentsThree(), hotel_info_pnl);
            holdFormData();
        }

        private void img_browse_btn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    hotel_profile_img.Image = new Bitmap(dialog.FileName);
                    image_location_inp.Text = dialog.FileName;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("error");
            }

        }

        private void setFormData()
        {
            if(hold.get_owner() != null)
            {
                owner_name_inp.Text = hold.get_owner();
            }
            if(hold.get_phno() != null)
            {
                phone_number_inp.Text = hold.get_phno().ToString();
            }
            if(hold.get_fair() != 0)
            {
                fair_inp.Text = hold.get_fair().ToString();
            }

            Byte[] img = pic.getHotelPic(hold.get_hid());
            if (img != null)
            {
                using (MemoryStream ms = new MemoryStream(img))
                {
                    hotel_profile_img.Image = Image.FromStream(ms);
                }

            }
        }

        private void holdFormData()
        {
            
            try
            {
                byte[] img = ImageToByteArray(hotel_profile_img.Image);
                byte[] ImageToByteArray(Image image)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        return ms.ToArray();
                    }
                }
                hkey.setHotelInfo(owner_name_inp.Text, phone_number_inp.Text, int.Parse(fair_inp.Text), img);

            }
            catch(Exception e)
            {
                
            }
        }
    }
}
