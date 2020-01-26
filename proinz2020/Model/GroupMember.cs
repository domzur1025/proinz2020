using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class GroupMember
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Group Group { get; set; }
        public GroupMemberType.Type MemberType { get; set; }
        public DateTime JoinAt { get; set; }
    }
}
