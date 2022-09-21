using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Country
    {
        public Country()
        {
            Flights = new HashSet<Flight>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public virtual ICollection<Flight> Flights { get; set; }
    }
}
