using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL.Interfaces;

namespace DAL
{
    public class FlightDAL: IFlightDAL
    {
        TravelAgencyContext _context = new TravelAgencyContext();
        public List<Flight> GetAllFlights() 
        {
            try
            {
                return _context.Flights.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Flight> FilterFlights(int? countryId, DateTime? departureDate, DateTime? returnDate)
        {
            try
            {
                List<Flight> flights=new List<Flight>();
                if (countryId!=null)
                {
                    flights= _context.Flights.Where<Flight>(x => x.CountryId.Equals(countryId)).ToList();
                }
                if (departureDate!=null)
                {
                    flights = flights.Where<Flight>(x => x.DepartureDate.Equals(departureDate)).ToList();
                }
                if (returnDate!=null)
                {
                    flights = flights.Where<Flight>(x => x.ReturnDate.Equals(returnDate)).ToList();
                }
                return flights;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Flight getFlightById(int flightId)
        {
            Flight flight = _context.Flights.SingleOrDefault(x => x.Id.Equals(flightId));
            return flight;
        }
        public bool AddFlight(Flight flight)
        {
            try
            {
                _context.Flights.Add(flight);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteFlight(int id)
        {
            try
            {
                Flight flight = _context.Flights.SingleOrDefault(x => x.Id == id);
                _context.Flights.Remove(flight);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateFlight(Flight flight,int id )
        {
            try
            {
                Flight currentFlight = _context.Flights.SingleOrDefault(x => x.Id == id);
                _context.Entry(currentFlight).CurrentValues.SetValues(flight);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

}
