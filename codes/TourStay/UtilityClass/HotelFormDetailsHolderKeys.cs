using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TourStay.UtilityClass
{
    internal class HotelFormDetailsHolderKeys
    {
        private HotelInfoHolder key = new HotelInfoHolder();
        private HotelFormDataHolder data = new HotelFormDataHolder();

        public void setHotelInfo(string owner_name, string ph_no, int hotel_fair, byte[] img)
        {
            key.set_owner(owner_name);
            key.set_phno(ph_no);
            key.set_fair(hotel_fair);
            key.set_img(img);
        }

        public void setHotelComponentsOne(string ac, string fridge, string wifi, string tv) 
        {
            data.set_ac(ac);
            data.set_fridge(fridge);
            data.set_wifi(wifi);
            data.set_tv(tv);
        }

        public void setHotelComponentsTwo(string view, string kitchen, string dining)
        {
            data.set_view(view);
            data.set_kitchen(kitchen);
            data.set_dining(dining);
        }

        public void setHotelComponentsThree(string travel, string food, string parking)
        {
            data.set_travel(travel);
            data.set_food(food);
            data.set_parking(parking);
        }
    }
}
