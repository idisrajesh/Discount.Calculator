using Discount.Calculator.Domain.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Discount.Calculator.Domain.interfaces.services
{
    public interface IUserService
    {
         void AddTestUser();
        public bool ValidateUser(UserModel userModel);
        public string AutheticateUser(UserModel userModel);
    }
}
