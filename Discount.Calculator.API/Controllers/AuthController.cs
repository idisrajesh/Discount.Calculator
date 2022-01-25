using Discount.Calculator.Domain.interfaces.services;
using Discount.Calculator.Domain.models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Discount.Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        IUserService _userService;
        public AuthController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("[action]")]
        public IActionResult Login(UserModel user)
        {
            IActionResult response = Unauthorized();
            bool Isvalid = _userService.ValidateUser(user);
            if (Isvalid)
            {
                string token = _userService.AutheticateUser(user);
                response = Ok(new { token=token});
            }

            return response;
        }
    }
}
