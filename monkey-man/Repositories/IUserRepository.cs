using System.Collections.Generic;

using monkey_man.Models;

namespace monkey_man.Repositories
{
    public interface IUserRepository
    {
        public List<User> getUsers();
        public bool addUser(User u);
    }
}