using DAL.Models;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IFlightBL
    {
        List<FlightDTO> GetAllFlights();
        List<FlightDTO> FilterFlights(int? countryId, DateTime? departureDate, DateTime? returnDate);
        public FlightDTO getFlightById(int flightId);
        bool AddFlight(FlightDTO flight);

        public bool DeleteFlight(int id);
        public bool UpdateFlight(FlightDTO flight,int id);
    }
}
