using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Message
    {
        public int Id { get; set; }
        public String Content { get; set; }
        public DateTime SentAt { get; set; }
        public Conversation Conversation { get; set; }
    }
}
