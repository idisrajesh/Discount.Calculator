using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discount.Calculator.Domain.interfaces.services;

namespace Discount.Calculator.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountCalculatorController : ControllerBase
    {
        private readonly IDiscountCalculatorService _discountCalculatorService;

        public DiscountCalculatorController(IDiscountCalculatorService discountCalculatorService)
        {
            _discountCalculatorService = discountCalculatorService;
        }
        [HttpGet]
        [Authorize]
        [Route("[action]")]
        public IActionResult GetPrice(float gram,float price,float discountAmount=0)
        {
            var result = _discountCalculatorService.GetPrice(gram, price, discountAmount);
            return Ok(result);
        }
    }
}
