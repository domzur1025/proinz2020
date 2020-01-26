using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Conversation
    {
        public int Id { get; set; }
        public User FirstUser { get; set; }
        public User SecondUser { get; set; }
    }
}
