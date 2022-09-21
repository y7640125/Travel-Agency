using BL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private ILogger _logger;
        private IUserBL _userBL;

        public UserController(IUserBL userBL, ILogger<UserController> logger)
        {
            _userBL = userBL;
            _logger = logger;
        }

        [HttpGet]
        [Route("IncreaseCount")]
        public int IncreaseCount()
        {
            return _userBL.IncreaseCount();
        }

        [HttpGet]
        [Route("login/{email}/{password}")]
        public User Login(string email, string password)
        {
            try
            {
                _logger.LogInformation($"enter to function login {email} {password}");
                User user = _userBL.Login(email,password);
                return user;
            }
            catch (Exception ex)
            {
                _logger.LogError("this is exeption${ex.Message}");
                throw ex;
            }
        }
        [HttpGet]
        [Route("Users")]
        public IActionResult GetAllUsers()
        {
            try
            {
                return Ok(_userBL.GetAllUsers());
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public bool AddUser([FromBody] User user)
        {
            var x = _userBL.AddUser(user);
            return x;
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public bool DeleteUser(int id)
        {
            return _userBL.DeleteUser(id);
        }

        [HttpPut]
        [Route("update/{id}")]
        public bool UpdateUser(int id, [FromBody] User user)
        {
            return _userBL.UpdateUser(id, user);
        }
    }
}
