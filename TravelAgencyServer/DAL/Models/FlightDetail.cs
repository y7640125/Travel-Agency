using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class FlightDetail
    {
        public int OrderId { get; set; }
        public int FlightId { get; set; }
        public int UserId { get; set; }

        public virtual Flight Flight { get; set; }
        public virtual User User { get; set; }
    }
}
