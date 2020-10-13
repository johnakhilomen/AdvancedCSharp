using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Delegates
{
    public class UserDataAdapter
    {
        public Task<User> AddUser(User user)
        {
            Console.WriteLine("User "+user.Username + " Added");
            return Task.Run(()=>
            {
                return user;
            });
        }

        public Task<User> GetUser(User user)
        {
            return Task.Run(()=>
            {
                return user;
            });
        }

        public Task<List<User>> GetUsers()
        {
            return Task.Run(() =>
            {
                return new List<User>{
                new User { Username = "Joe", Address = "Some Address" },
                new User { Username = "Bob", Address = "Some Address" }
            };
            });
        }
    }
}
