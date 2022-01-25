using System;
using System.Collections.Generic;
using System.Text;

namespace Discount.Calculator.Domain.interfaces.services
{
    public interface ICommonServices
    {
         string GenerateJSONWebToken(string userName, int tokenExpiresIn = 120);
       
    }
}
