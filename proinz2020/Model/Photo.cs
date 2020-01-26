using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Photo
    {
        public int Id { get; set; }
        public String FileName { get; set; }
        public User User { get; set; }
        public DateTime AddAt { get; set; }
    }
}
