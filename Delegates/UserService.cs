using System;
using System.Threading.Tasks;

namespace Delegates
{
    public class UserService
    {
        public void ProcessUser(Func<User, Task<User>> addUserHandler, User user)
        {
            addUserHandler(user);
        }
    }
}
