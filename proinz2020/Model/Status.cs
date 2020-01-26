using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class Status
    {
        public enum FriendStatus { INVITE, ADDED, REJECTED}
        public enum AccountStatus { UNCONFIRMED, CONFIRMED, BANNED}
    }
}
