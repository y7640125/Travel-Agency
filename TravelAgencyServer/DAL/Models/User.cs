﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class User
    {
        public User()
        {
            FlightDetails = new HashSet<FlightDetail>();
        }

        public int Id { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public bool? Advertisements { get; set; }

        public virtual Role Role { get; set; }
        public virtual Credit Credit { get; set; }
        public virtual ICollection<FlightDetail> FlightDetails { get; set; }
    }
}
