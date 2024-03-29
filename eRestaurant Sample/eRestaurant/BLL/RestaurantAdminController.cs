﻿using eRestaurant.DAL;
using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.BLL
{
    [DataObject]
    public class RestaurantAdminController
    {
        #region Manage Waiters
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert,false)]
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
        [DataObjectMethod(DataObjectMethodType.Update, false)]
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
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
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
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Waiter> ListAllWaiters()
        {
            using(RestaurantContext context = new RestaurantContext())
            {
                return context.Waiters.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Waiter GetWaiter(int waiterId)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Waiters.Find(waiterId);
            }
        }
        #endregion
        #endregion

        #region Manage Tables
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddTable(Table item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation of waiter data
                var added = context.Tables.Add(item);
                context.SaveChanges();
                return added.TableID;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateTable(Table item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation
                var attatched = context.Tables.Attach(item);
                var matchingWithExistingValues = context.Entry<Table>(attatched); // Lookup info about a object in the database
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteTable(Table item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.Tables.Find(item.TableID);
                context.Tables.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Table> ListAllTables()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Tables.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Table GetTable(int tableId)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Tables.Find(tableId);
            }
        }
        #endregion
        #endregion

        #region Manage Items
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public int AddItem(Item item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation of waiter data
                var added = context.Items.Add(item);
                context.SaveChanges();
                return added.ItemID;
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateItem(Item item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation
                var attatched = context.Items.Attach(item);
                var matchingWithExistingValues = context.Entry<Item>(attatched); // Lookup info about a object in the database
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteItem(Item item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.Items.Find(item.ItemID);
                context.Items.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<Item> ListAllItems()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Items.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Item GetItem(int itemId)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.Items.Find(itemId);
            }
        }
        #endregion
        #endregion

        #region Manage Special Event
        #region Command
        [DataObjectMethod(DataObjectMethodType.Insert, false)]
        public void AddSpecialEvent(SpecialEvent item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation of waiter data
                var added = context.SpecialEvents.Add(item);
                context.SaveChanges();
 
            }
        }
        [DataObjectMethod(DataObjectMethodType.Update, false)]
        public void UpdateSpecialEvent(SpecialEvent item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                // Validation
                var attatched = context.SpecialEvents.Attach(item);
                var matchingWithExistingValues = context.Entry<SpecialEvent>(attatched); // Lookup info about a object in the database
                matchingWithExistingValues.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Delete, false)]
        public void DeleteSpecialEvent(SpecialEvent item)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                var existing = context.Items.Find(item.EventCode);
                context.Items.Remove(existing);
                context.SaveChanges();
            }
        }
        #endregion
        #region Query
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SpecialEvent> ListAllSpecialEvents()
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public SpecialEvent GetSpecialEvent(int eventCode)
        {
            using (RestaurantContext context = new RestaurantContext())
            {
                return context.SpecialEvents.Find(eventCode);
            }
        }
        #endregion
        #endregion
    }
}
