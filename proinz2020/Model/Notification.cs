using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Notification
    {
        public int Id { get; set; }
        public bool Seen { get; set; }
        public int IdOfContent { get; set; }
        public NotificationType.Type Type { get; set; }
    }
}
