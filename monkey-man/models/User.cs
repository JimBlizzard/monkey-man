using System.Collections.Generic;

namespace monkey_man.Models
{
    public class User
    {
        public string Name { get; set; }
        public int Role { get; set; }
        public string Location { get; set; }
        public List<Category> Categories { get; set; }
    }
}
