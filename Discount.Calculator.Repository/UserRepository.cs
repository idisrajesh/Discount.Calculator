using System;
using System.Collections.Generic;
using System.Text;
using Discount.Calculator.Domain.interfaces.repository;
using Discount.Calculator.Domain.dbModels;
using System.Linq;
using Discount.Calculator.Domain.models;

namespace Discount.Calculator.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly ApiContext _dbContext;
         
        public UserRepository(ApiContext context)
        {
            _dbContext = context;
         }
        public void AddTestUser()
        {
            List<User> userList = new List<User>();
            var user1 = new User
            {
                Id = 1,
                FirstName = "TestUser1",
                LastName = "",
                UserName = "TestUser1",
                Password = "TestUser1@123"
            };

            var user2 = new User
            {
                Id = 2,
                FirstName = "TestUser2",
                LastName = "",
                UserName = "TestUser2",
                Password = "TestUser2@123"
            };
            userList.Add(user1);
            userList.Add(user2);
            _dbContext.AddRange();
            _dbContext.SaveChanges();
        }
        public bool ValidateUser(UserModel userModel)
        {
            var user = _dbContext.Users.ToList();
            return _dbContext.Users.Any(x=>x.UserName==userModel.UserName && x.Password == userModel.Password);
        }

    }


}
