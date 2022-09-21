using BL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpdateController : ControllerBase
    {
        private IUpdateBL _updateBL;
        public UpdateController(IUpdateBL update)
        {
            _updateBL = update;
        }

        [HttpGet]
        [Route("Updates")]
        public IActionResult GetAllUpdates()
        {
            try
            {
                return Ok(_updateBL.GetAllUpdates());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public bool AddUpdate([FromBody] Update Update)
        {
            var x = _updateBL.AddUpdate(Update);
            return x;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteUpdate(int id)
        {
            return _updateBL.DeleteUpdate(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateUpdate(int id, [FromBody] Update Update)
        {
            return _updateBL.ChangeUpdate(id, Update);
        }
    }
}
