using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourStay.UtilityClass
{
    internal class TempSpotCard
    {
        private static string phno;
        public void set_phno(string ph)
        {
            phno = ph;
        }

        public string get_phno()
        {
            return phno;
        }
    }
}
