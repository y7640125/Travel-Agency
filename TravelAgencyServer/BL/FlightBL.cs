using BL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using AutoMapper;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FlightBL: IFlightBL
    {
        IFlightDAL _flightDAL;
        IMapper mapper;
        public FlightBL(IFlightDAL flightDAL)
        {

            _flightDAL = flightDAL;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<AutoMapperProfile>();

            });
            mapper = config.CreateMapper();
        }

        public List<FlightDTO> GetAllFlights()
        {

            List<Flight> flights = _flightDAL.GetAllFlights();

            return mapper.Map<List<Flight>, List<FlightDTO>>(flights);

        }
        public List<FlightDTO> FilterFlights(int? countryId, DateTime? departureDate, DateTime? returnDate)
        {

            List<Flight> flights = _flightDAL.FilterFlights(countryId, departureDate, returnDate);

            return mapper.Map<List<Flight>, List<FlightDTO>>(flights);

        }
        public FlightDTO getFlightById(int flightId)
        {

            Flight flight = _flightDAL.getFlightById(flightId);

            return mapper.Map<Flight, FlightDTO>(flight);

        }
        public bool AddFlight(FlightDTO flight)
        {
            return _flightDAL.AddFlight(mapper.Map<FlightDTO, Flight>(flight));
        }

        public bool DeleteFlight(int id)
        {
            return _flightDAL.DeleteFlight(id);
        }

        public bool UpdateFlight(FlightDTO flight,int id )
        {
            return _flightDAL.UpdateFlight(mapper.Map<FlightDTO, Flight>(flight),id);
        }
    }
}
