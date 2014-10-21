using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using eRestaurant.DLL;
using eRestaurant.Entities;
using eRestaurant.Entities.DTOs;

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

        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<Category> ListCategoryMenuItem()
        {
            using(var context = new RestaurantContext())
            {
                var data = from cat in context.MenuCategories
                           orderby cat.Description
                           select new Category() // Anonymous type
                           {
                               Description = cat.Description,
                               MenuItems =    from item in cat.MenuItems
                                              where item.Active
                                              orderby item.Description
                                              select new MenuItem()
                                              {
                                                  Description = item.Description,
                                                  Price = item.CurrentPrice,
                                                  Calories = item.Calories,
                                                  Comment = item.Comment
                                              }
                           };

                return data.ToList();
            }
        }

        
    }
}
