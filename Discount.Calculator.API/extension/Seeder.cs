using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Discount.Calculator.Domain.dbModels;
using Discount.Calculator.Domain.interfaces.services;

namespace Discount.Calculator.API.extension
{
    public class Seeder
    {
        public  static  IUserService _userService;
        public Seeder(IUserService user)
        {
            _userService = user;
        }

        public static void AddUser(ApiContext context)
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
            context.AddRange(userList);
            context.SaveChanges();
        }
    }
}
