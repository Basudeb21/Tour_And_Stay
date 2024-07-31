using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TourStay.UtilityClass
{
    internal class HotelFormDataHolder
    {
        private static string h_ac;
        private static string h_tv;
        private static string h_fridge;
        private static string h_wifi;
        private static string h_view;
        private static string h_kitchen;
        private static string h_dining;
        private static string h_travel;
        private static string h_food;
        private static string h_parking;



        public void set_ac(string ac)
        {
            h_ac = ac;
        }
        public string get_ac()
        {
            return h_ac;
        }

        public void set_tv(string tv)
        {
            h_tv = tv;
        }
        public string get_tv()
        {
            return h_tv;
        }

        public void set_fridge(string fridge)
        {
            h_fridge = fridge;
        }
        public string get_fridge()
        {
            return h_fridge;
        }

        public void set_wifi(string wifi)
        {
            h_wifi = wifi;
        }
        public string get_wifi()
        {
            return h_wifi;
        }
        public void set_view(string view)
        {
            h_view = view;
        }
        public string get_view()
        {
            return h_view;
        }
        public void set_kitchen(string kitchen)
        {
            h_kitchen = kitchen;
        }
        public string get_kitchen()
        {
            return h_kitchen;
        }
        public void set_dining(string dining)
        {
            h_dining = dining;
        }
        public string get_dining()
        {
            return h_dining;
        }

        public void set_travel(string travel)
        {
            h_travel = travel;
        }
        public string get_travel()
        {
            return h_travel;
        }
        public void set_food(string food)
        {
            h_food = food;
        }
        public string get_food()
        {
            return h_food;
        }

        public void set_parking(string parking)
        {
            h_parking = parking;
        }
        public string get_parking()
        {
            return h_parking;
        }


    }
}
