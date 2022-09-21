using BL.Interfaces;
using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FlightDetailBL : IFlightDetailBL
    {
        IFlightDetailDAL _flightDetailDAL;

        public List<FlightDetail> GetAllFlightDetail()
        {
            return _flightDetailDAL.GetAllFlightDetail();
        }
        public bool AddFlightDetail (FlightDetail  flightDetail)
        {
            return _flightDetailDAL.AddFlightDetail(flightDetail);
        }

        public bool DeleteFlightDetail (int id)
        {
            return _flightDetailDAL.DeleteFlightDetail(id);
        }

        public bool UpdateFlightDetail(int id, FlightDetail flightDetail)
        {
            return _flightDetailDAL.UpdateFlightDetail(id,flightDetail);
        }
    }
}
