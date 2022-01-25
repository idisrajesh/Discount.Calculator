using Discount.Calculator.Domain.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Discount.Calculator.Domain.interfaces.repository
{
    public interface IUserRepository
    {
        public void AddTestUser();
        public bool ValidateUser(UserModel userModel);
    }
}
