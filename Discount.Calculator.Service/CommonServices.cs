using System;
using System.Collections.Generic;
using System.Text;
using System.Security;
using System.Security.Claims;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using Discount.Calculator.Domain.interfaces.services;

namespace Discount.Calculator.Service
{
    public class CommonServices: ICommonServices
    {
        private IConfiguration _config;

        public CommonServices(IConfiguration configuration)
        {
            _config = configuration;
        }

        public string GenerateJSONWebToken(string userName, int tokenExpiresIn = 120)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, userName),// loginResponse.FirstName + " " + loginResponse.LastName),
              
            };

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              claims,
              expires: DateTime.Now.AddMinutes(tokenExpiresIn),
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

