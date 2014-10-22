using eRestaurant.DLL;
using eRestaurant.Entities.POCOs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace eRestaurant.BLL
{
    [DataObject]
    public class ReportController
    {
        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CategoryMenuItem> GetReportCategoryMenuItems()
        {
            using(var context = new RestaurantContext())
            {
                var results = from cat in context.Items
                             orderby cat.MenuCategory.Description, cat.Description
                             select new CategoryMenuItem()
                             {
                                 CategoryDescription = cat.MenuCategory.Description,
                                 ItemDescription = cat.Description,
                                 Price = cat.CurrentPrice,
                                 Calories = cat.Calories,
                                 Comment = cat.Comment
                             };
                return results.ToList();
            }
        }

        [DataObjectMethod(DataObjectMethodType.Select)]
        public List<CategorizedItemSale> TotalCategorizedItemSales()
        {
            using(var context = new RestaurantContext())
            {
                var results = from info in context.BillItems
                              orderby info.Item.MenuCategory.Description, info.Item.Description
                              select new CategorizedItemSale()
                              {
                                  CategoryDescription = info.Item.MenuCategory.Description,
                                  ItemDescription = info.Item.Description,
                                  Quantity = info.Quantity,
                                  Price = info.Saleprice * info.Quantity,
                                  Cost = info.UnitCost * info.Quantity
                              };
                return results.ToList();
            }
        }
    }
}
