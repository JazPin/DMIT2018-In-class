using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eRestaurant.DLL;
using eRestaurant.Entities;

namespace eRestaurant.BLL
{
    [DataObject]
    public class MenuItemController
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Item> ListMenuItems()
        {
            using (var context = new RestaurantContext())
            {
                // Lamda and use the method style of the include -> System.Data.Entity;
                // Get the Item data and include the Category data for each item.
                // The .Include() method on the Dbset<T> class performs "eager loading" of data.
                return context.Items.Include(it => it.MenuCategory).ToList();
            }
        }
    }
}
