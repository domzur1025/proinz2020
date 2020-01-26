using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Post
    {
        public int Id { get; set; }
        public User Author { get; set; }
        public String Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastEditionAt { get; set; }
        public List<Photo> Photos { get; set; }
    }
}
