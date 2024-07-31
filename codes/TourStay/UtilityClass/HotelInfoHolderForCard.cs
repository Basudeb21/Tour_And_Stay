using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourStay.UtilityClass
{
    internal class HotelInfoHolderForCard
    {
        private int h_id;
        
        public void set_hid(int id)
        {
            h_id = id;
        }
        public int get_hid()
        {
            return h_id;
        }
    }
}
