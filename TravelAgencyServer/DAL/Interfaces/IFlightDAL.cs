using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IFlightDAL
    {
        List<Flight> GetAllFlights();
        List<Flight> FilterFlights(int? countryId, DateTime? departureDate, DateTime? returnDate);
        public Flight getFlightById(int flightId);
        bool AddFlight(Flight flight);

        public bool DeleteFlight(int id);
        public bool UpdateFlight(Flight flight,int id);
    }
}
