using System;
using System.Collections.Generic;
using System.Text;
using Discount.Calculator.API.Controllers;
using Discount.Calculator.Domain.interfaces.services;
using Discount.Calculator.Domain.interfaces.repository;
using Discount.Calculator.Service;
using Discount.Calculator.Repository;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace Discount.Calculator.Test
{
    public class DiscountCalculatorTest
    {
        private readonly DiscountCalculatorController discountCalculatorController;
        private readonly IDiscountCalculatorService discountCalculatorService;
        
        public DiscountCalculatorTest()
        {
            discountCalculatorService = new DiscountCalculatorService();
            discountCalculatorController = new DiscountCalculatorController(discountCalculatorService);
        }

        [Fact]
        public void TestGetPrice()
        {
            var okResult = discountCalculatorController.GetPrice(10, 1000);
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
            Assert.Equal(10000, Convert.ToInt32((okResult as OkObjectResult).Value));
        }

        [Fact]
        public void TestGetPriceDiscount()
        {
            var okResult = discountCalculatorController.GetPrice(10, 1000,5);
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
            Assert.Equal(9500, Convert.ToInt32((okResult as OkObjectResult).Value));
        }
        [Fact]
        public void TestGetPriceWithDiscountDouble()
        {
            var okResult = discountCalculatorController.GetPrice(12, 1124, 5);
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
            Assert.Equal(12813.6, Convert.ToDouble((okResult as OkObjectResult).Value),1);
        }
    }
}
