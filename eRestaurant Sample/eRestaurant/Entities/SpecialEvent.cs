﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class SpecialEvent
    {
        #region Public Prpoerties
        [Key]
        [Required(ErrorMessage="An Event Code is required (one character only)")]
        [StringLength(1, ErrorMessage="Event Codes can only use a single-character code")]
        public string EventCode { get; set; }
        [Required(ErrorMessage = "A Decription is required (5-30 characters)")]
        [StringLength(30,MinimumLength=5,ErrorMessage="Description must br from 5 to 30 characters in length")]
        public string Description { get; set; }
        public bool Active { get; set; }
        #endregion

        #region Navigation  properties
        public virtual ICollection<Reservation> Reservations { get; set; }
        #endregion
    }
}
