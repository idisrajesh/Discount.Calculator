using System;
using System.Collections.Generic;
using System.Text;


namespace Discount.Calculator.Domain.interfaces.services
{
    public interface IDiscountCalculatorService
    {
        public float GetPrice(float gram, float price, float discountAmount = 0);
    }
}
