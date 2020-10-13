using System;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            UserService userService = new UserService();
            UserDataAdapter userDataAdapter = new UserDataAdapter();
            Func<User, Task<User>> addUserDel = userDataAdapter.AddUser;
            var user = new User
            {
                Username = "JoeUser",
                Address = "Joe's Address"
            };
            userService.ProcessUser(addUserDel, user);
        }

         
    }
}
