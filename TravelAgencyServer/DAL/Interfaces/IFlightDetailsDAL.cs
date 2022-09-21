using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IFlightDetailDAL
    {
        List<FlightDetail> GetAllFlightDetail();
        bool AddFlightDetail(FlightDetail flightDetails);
        bool DeleteFlightDetail(int id);
        bool UpdateFlightDetail(int id, FlightDetail flightDetails);
    }
}
