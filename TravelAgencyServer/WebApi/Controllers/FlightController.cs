using BL.Interfaces;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : ControllerBase
    {
        private IFlightBL _flightBL;

        public FlightController(IFlightBL flight)
        {
            _flightBL = flight;
        }

        [HttpGet]
        [Route("Flights")]
        public IActionResult GetAllFlights()
        {
            try
            {
                return Ok(_flightBL.GetAllFlights());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("filter")]
        public IActionResult FilterFlights([FromQuery] int? countryId, [FromQuery] DateTime? departureDate, [FromQuery] DateTime? returnDate)
        {
            try
            {
                return Ok(_flightBL.FilterFlights(countryId, departureDate, returnDate));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("FlightById")]
        public IActionResult getFlightById(int flightId)
        {
            try
            {
                return Ok(_flightBL.getFlightById(flightId));
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public bool AddFlight([FromBody] FlightDTO flight)
        {
            var x = _flightBL.AddFlight(flight);
            return x;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteFlight(int id)
        {
            return _flightBL.DeleteFlight(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateFlight( [FromBody] FlightDTO flight,int id)
        {
            return _flightBL.UpdateFlight( flight,id);
        }
    }
}
