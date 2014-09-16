using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class BillItem
    {
        [Key, Column(Order = 1)]
        public int BillID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int ItemID { get; set; }

        public int Quantity { get; set; }
        public decimal Saleprice { get; set; }
        public decimal UnitCost { get; set; }
        public string Notes { get; set; }

        #region Navigation  properties
        public virtual Bill Bills { get; set; }
        public virtual Item Item { get; set; }
        #endregion
    }
}
