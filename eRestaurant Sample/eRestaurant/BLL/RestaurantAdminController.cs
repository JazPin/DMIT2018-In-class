using eRestaurant.DLL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
    public class RestaurantAdminController
    {
        #region Manage Waiters
        #region Command
        public int AddWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation of waiter data
                var added = context.Waiters.Add(item);
                context.SaveChanges();
                return added.WaiterID;
            }
        }
        public void UpdateWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation
                var attatched = context.Waiters.Attach(item);
                var matchingWithExistingValues = context.Entry<Waiter>(attatched); // Lookup info about a object in the database
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        public void DeleteWaiter(Waiter item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.Waiters.Find(item.WaiterID);
                context.Waiters.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        public List<Waiter> ListAllWaiters()
        {
            throw new NotImplementedException();
        }
        public Waiter GetWaiter(int waiterId)
        {
            throw new NotImplementedException();
        }
        #endregion
        
        #endregion

        #region Manage Tables
        #region Command

        #endregion
        #region Query

        #endregion
        #endregion

        #region Manage Items
        #region Command

        #endregion
        #region Query

        #endregion
        #endregion

        #region Manage Special Event
        #region Command

        #endregion
        #region Query

        #endregion
        #endregion
    }
}
