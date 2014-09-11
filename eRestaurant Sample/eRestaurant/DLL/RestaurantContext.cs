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
        #endregion
    }
}
