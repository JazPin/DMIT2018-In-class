using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; // Needed for accessing my entity classes
using eRestaurant.Entities; // Needed for DbContext base class
namespace eRestaurant.DLL
{
    class RestaurantContext : DbContext 
    {
        // Constructor that calls a base-class constructor to specify the 
        // connection string we need to use
        public RestaurantContext() : base("name=EatIn") { }

        #region Table to Entity mappings
        public DbSet<Table> Tables { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Bill> Bills { get; set; }
        public DbSet<BillItem> BillItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<MenuCategories> MenuCategories { get; set; }
        public DbSet<Waiters> Waiters { get; set; }
        #endregion
    }
}
