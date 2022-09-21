using BL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private IMessageBL _messageBL;
        public MessageController(IMessageBL message)
        {
            _messageBL = message;
        }

        [HttpGet]
        [Route("Messages")]
        public IActionResult GetAllMessages()
        {
            try
            {
                return Ok(_messageBL.GetAllMessages());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost]
        [Route("add")]
        public bool AddMessage([FromBody] Message Message)
        {
            var x = _messageBL.AddMessage(Message);
            return x;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteMessage(int id)
        {
            return _messageBL.DeleteMessage(id);
        }

        [HttpPut]
        [Route("Update/{id}")]
        public bool UpdateMessage(int id, [FromBody] Message Message)
        {
            return _messageBL.UpdateMessage(id, Message);
        }
    }
}
