using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Group
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public User Creator { get; set; }
        public String Description { get; set; }
    }
}
