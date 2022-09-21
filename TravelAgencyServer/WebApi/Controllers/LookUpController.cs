using BL;
using BL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookUpController : ControllerBase
    {
        private ILookUpBL _lookUpBL;
        public LookUpController(ILookUpBL lookUp)
        {
            _lookUpBL = lookUp;
        }

        [HttpGet]
        [Route("Airlines")]
        public IActionResult GetAllAirlines()
        {
            try
            {
                return Ok(_lookUpBL.GetAllAirlines());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("Countries")]
        public IActionResult GetAllCountries()
        {
            try
            {
                return Ok(_lookUpBL.GetAllCountries());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpGet]
        [Route("Roles")]
        public IActionResult GetAllRoles()
        {
            try
            {
                return Ok(_lookUpBL.GetAllRoles());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
