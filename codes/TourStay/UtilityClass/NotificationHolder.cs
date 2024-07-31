using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourStay.UtilityClass
{
    internal class NotificationHolder
    {
        private static string user_mobile;
        private static int hid;
        private static string message;
        private static string status;
        private static string facilitie;

        public void set_user_mobile(string mobile)
        {
            user_mobile = mobile;
        }

        public string get_user_mobile()
        {
            return user_mobile;
        }

        public void set_hid(int id)
        {
            hid = id;
        }
        public int get_hid()
        {
            return hid;
        }

        public void set_message(string msg) 
        {
            message = msg;
        }
        public string get_message()
        {
            return message;
        }
        public void set_status(string sts)
        {
            status = sts;
        }

        public string get_status()
        {
            return status;
        }

        public void set_facilities(string fac)
        {
            facilitie = fac;
        }

        public string get_facilities()
        {
            return facilitie;
        }
    }
}
