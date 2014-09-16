using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Items
    {
        public int ItemID { get; set; }
        public string Description { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal CurrentCost  { get; set; }
        public bool Active { get; set; }
        public int Calories { get; set; }
        public string Comment { get; set; }
        public int MenuCategoryID { get; set; }

        #region Navigation  properties
        public virtual MenuCategories MenuCategory{ get; set; }
        public virtual ICollection<BillItems> BillItems { get; set; }
        #endregion
    }
}
