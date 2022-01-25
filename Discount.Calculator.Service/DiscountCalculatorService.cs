using System;
using System.Collections.Generic;
using System.Text;
using Discount.Calculator.Domain.interfaces.services;
namespace Discount.Calculator.Service
{
   public  class DiscountCalculatorService:IDiscountCalculatorService
    {
        public float GetPrice(float gram, float price, float discountAmount )
        {
            float totalprice = gram * price;
            if (discountAmount > 0)
            {
                float discountPrice = totalprice - (totalprice * discountAmount / 100);
                return discountPrice;
            }
            return totalprice;
        }
    }
}
