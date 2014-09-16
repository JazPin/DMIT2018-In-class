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
        public int AddWaiter(Waiters item)
        {
            throw new NotImplementedException();
        }
        public void UpdateWaiter(Waiters item)
        {

        }
        public void DeleteWaiter(Waiters item)
        {

        }
        #endregion
        #region Query
        public List<Waiters> ListAllWaiters()
        {
            throw new NotImplementedException();
        }
        public Waiters GetWaiter(int waiterId)
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
