using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace proinz2020.Model
{
    public class User
    {
        public int Id { get; set; }
        public String Lirstname { get; set; }
        public String Lastname { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public CountryCode CountryCode { get; set; }
        public Photo ProfilePhoto { get; set; }
        public Status.AccountStatus Status { get; set; }
        public AccountType.Role Role { get; set; }
    }
}
