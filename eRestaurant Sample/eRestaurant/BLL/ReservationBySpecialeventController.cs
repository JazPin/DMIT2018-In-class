using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eRestaurant.Entities;
using eRestaurant.DLL;

namespace eRestaurant.BLL
{
    [DataObject]
    public class ReservationBySpecialeventController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListSpecialEvent()
        {
            using (var context = new RestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Reservation> ListReservationBySpecialEvent(string eventCode)
        {
            using (var context = new RestaurantContext())
            {
                var datalist =  from data in context.Reservations
                                where data.EventCode == eventCode
                                select data;

                return datalist.ToList();
            }
        }
    }
}
