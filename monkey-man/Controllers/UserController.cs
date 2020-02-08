using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using monkey_man.Repositories;
using monkey_man.Models;

namespace monkey_man.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {   
        private UserRepository userRepository;

        [HttpPut]
        public bool Put([FromBody] User user) 
        {
            return userRepository.addUser(user); // returns true if user added
        }

        // receive 
        [HttpGet]
        public List<User> Get()
        {
            return userRepository.getUsers();
        }
    }
}
