﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Like
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public User Author { get; set; }
    }
}
