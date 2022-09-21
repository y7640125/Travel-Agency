using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interfaces
{
    public interface IFlightDetailBL
    {
        List<FlightDetail> GetAllFlightDetail();
        bool AddFlightDetail(FlightDetail flightDetail);
        bool DeleteFlightDetail(int id);
        bool UpdateFlightDetail(int id, FlightDetail flightDetail);
    }
}
