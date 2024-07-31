using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourStay.UtilityClass
{
    internal class UserLoginInfoHolder
    {
        private static string u_name;
        private static string u_password;
        private static string u_phno;
        private static string u_email="";
        private static byte[] u_img = null;

        public void u_nameSet(string name) {
            u_name = name;
        }

        public void u_phnoSet(string phno)
        {
            u_phno = phno;
        }

        public void u_passwordSet(string password)
        {
            u_password = password;
        }

        public void u_emailSet(string email)
        {
            u_email = email;
        }
        
        public void u_imgSet(byte[] img)
        {
            u_img = img;
        }

        public string u_nameGet()
        {
            return u_name;
        }

        public string u_phnoGet()
        {
            return u_phno;
        }

        public string u_passwordGet()
        {
            return u_password;
        }

        public string u_emailGet()
        {
            return u_email;
        }

        public byte[] u_imgGet()
        {
            return u_img;
        }

    }
}
