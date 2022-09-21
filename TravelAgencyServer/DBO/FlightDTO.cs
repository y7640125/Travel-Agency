using DAL.Models;
using System;

namespace DTO
{
    public class FlightDTO
    {
        public int Id { get; set; }
        public int AirlineId { get; set; }
        public Airline airline { get; set; }
        public int CountryId { get; set; }
        public Country country { get; set; }    
        public string Image { get; set; }
        public int? Price { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public int? NumSeats { get; set; }
        public int? NumPassengers { get; set; }
        public User[] passengers { get; set; }
        public string Update { get; set; }

        //public virtual Airline Airline { get; set; }
        //public virtual Country Country { get; set; }
        //public virtual ICollection<FlightDetail> FlightDetails { get; set; }

    }
}
