using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Table
    {
        // By Convention, if we use a property with the same name as the class, 
        // but with a suffix of ID, then Entity Framework will recongnize that property 
        // as mapping to the database table's Primary Key column.
        public int TableID { get; set; }
        public byte TableNumber { get; set; }
        public bool Smoking { get; set; }
        public int Capacity { get; set; }
        public bool Available { get; set; }

        #region Navigation  properties
        public virtual ICollection<Bill> Bills { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    }
}
