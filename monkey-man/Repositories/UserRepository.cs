using System.Collections.Generic;
using monkey_man.Models;

namespace monkey_man.Repositories
{
    public class UserRepository : IUserRepository
    {
        public List<User> getUsers()
        {
            return new List<User>();
        }
        
        public bool addUser(User user)
        {
            return true;
        }
    }
}