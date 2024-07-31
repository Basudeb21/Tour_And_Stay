using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TourStay.UtilityClass
{
    internal class HotelInfoHolder
    {
        private static int h_id;
        private static string h_phno;
        private static int h_fair;
        private static string h_password;
        private static string h_owner;
        private static string h_country;
        private static string h_state;
        private static string h_spot;
        private static int h_pin;
        private static byte[] h_img = null;


        public void set_hid(int id)
        {
            h_id = id;
        }
        public int get_hid()
        {
            return h_id;
        }

        public void set_phno(string phno)
        {
            h_phno = phno;
        }
        public string get_phno()
        {
            return h_phno;
        }

        public void set_fair(int fair)
        {
            h_fair = fair;
        }
        public int get_fair()
        {
            return h_fair;
        }

        public void set_password(string pass)
        {
            h_password = pass;
        }
        public string get_password()
        {
            return h_password;
        }

        public void set_owner(string owner)
        {
            h_owner = owner;
        }
        public string get_owner()
        {
            return h_owner;
        }
        public void set_country(string country)
        {
            h_country = country;
        }
        public string get_country()
        {
            return h_country;
        }
        public void set_state(string state) {
            h_state = state;
        }
        public string get_state()
        {
            return h_state;
        }
        public void set_spot(string spot) {
            h_spot = spot;
        }
        public string get_spot()
        {
            return h_spot;
        }

        public void set_pin(int pin) {
            h_pin = pin;
        }
        public int get_pin()
        {
            return h_pin;
        }

        public void set_img(byte[] img) {
            h_img = img;
        }
        public byte[] get_img()
        {
            return h_img;
        }


    }
}
