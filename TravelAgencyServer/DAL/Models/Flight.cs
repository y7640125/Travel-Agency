using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class Flight
    {
        public Flight()
        {
            FlightDetails = new HashSet<FlightDetail>();
        }

        public int Id { get; set; }
        public int AirlineId { get; set; }
        public int CountryId { get; set; }
        public string Image { get; set; }
        public int? Price { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? NumSeats { get; set; }
        public int? NumPassengers { get; set; }
        public string Update { get; set; }

        public virtual Airline Airline { get; set; }
        public virtual Country Country { get; set; }
        public virtual ICollection<FlightDetail> FlightDetails { get; set; }
    }
}
