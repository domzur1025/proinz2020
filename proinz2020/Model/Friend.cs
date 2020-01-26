using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Friend
    {
        public int Id { get; set; }
        public User InvitingUser { get; set; }
        public User InvitedUser { get; set; }
        public Status.FriendStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime LastEditionAt { get; set; }
    }
}
