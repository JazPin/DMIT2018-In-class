using eRestaurant.DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
    [DataObject]
    public class AdhocController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public DateTime LastBillDate()
        {
            using(var context = new RestaurantContext())
            {
                var result = context.Bills.Max(x => x.BillDate);
                return result;
            }
        }
    }
}
