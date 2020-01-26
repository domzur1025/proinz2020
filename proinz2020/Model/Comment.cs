using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Comment
    {
        public int Id { get; set; }
        public String Content { get; set; }
        public Post Post { get; set; }
        public User Author { get; set; }
    }
}
