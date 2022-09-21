using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class FlightDetailDAL: IFlightDetailDAL
    {
        TravelAgencyContext _context = new TravelAgencyContext();
        public List<FlightDetail> GetAllFlightDetail()
        {
            try
            {
                return _context.FlightDetails.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public bool AddFlightDetail(FlightDetail flightDetails)
        {
            try
            {
                _context.FlightDetails.Add(flightDetails);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteFlightDetail(int id)
        {
            try
            {
                FlightDetail FlightDetails = _context.FlightDetails.SingleOrDefault(x => x.OrderId == id);
                _context.FlightDetails.Remove(FlightDetails);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool UpdateFlightDetail(int id, FlightDetail flightDetails)
        {
            try
            {
                FlightDetail currentFlightDetails = _context.FlightDetails.SingleOrDefault(x => x.OrderId == id);
                _context.Entry(currentFlightDetails).CurrentValues.SetValues(flightDetails);
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
