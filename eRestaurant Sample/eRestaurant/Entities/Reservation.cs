﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Reservation
    {
        //constants for valid reservaiton status values
        //B = Bookedl; A = Arrived; C = Complete; N = No-show; X = Cancelled
        public const string Booked = "B";
        public const string Arrived = "A";
        public const string Complete = "C";
        public const string NoShow = "N";
        public const string Cancelled = "X";


        public int ReservationID { get; set; }
        public string CustomerName { get; set; }
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public string ReservationStatus { get; set; }
        public string EventCode { get; set; }

        #region Navigation  properties
        public virtual SpecialEvent Event { get; set; }
        public virtual ICollection<Table> Tables { get; set; }
        public virtual ICollection<Bill> Bills { get; set; }
        #endregion
    }
}
