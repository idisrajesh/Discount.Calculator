using System;
using System.Collections.Generic;
using System.Text;
using Discount.Calculator.Domain.interfaces.services;
using Discount.Calculator.Domain.interfaces.repository;
using Discount.Calculator.Domain.models;

namespace Discount.Calculator.Service
{
    public class UserService: IUserService
    {
        public readonly IUserRepository _userRepository;
        public readonly ICommonServices _commonServices;
        public UserService(IUserRepository userRepository,ICommonServices commonServices)
        {
            _userRepository = userRepository;
            _commonServices = commonServices;
        }

        public void AddTestUser()
        {
            _userRepository.AddTestUser();
        }

        public bool ValidateUser(UserModel userModel)
        {
            return _userRepository.ValidateUser(userModel);
        }

        public string AutheticateUser(UserModel userModel)
        {
            string jwtToken = _commonServices.GenerateJSONWebToken(userModel.UserName);
            return jwtToken;
        }
    }
}
