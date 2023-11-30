using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class RegularUser : User
    {
        
        public RegularUser(string name, string password, int userId)
        {
            UserId = userId;
            Name = name;
            Password = password;
        }
        public static List<RegularUser> ExistingUsers()
        {
            var regularUsers = new List<RegularUser>();
            regularUsers.Add(new RegularUser("Börje", "kaffe123", 101));
            regularUsers.Add(new RegularUser("Stefan", "betong321", 102));
            regularUsers.Add(new RegularUser("Åke", "snus444",103));

            return regularUsers;
        }
        
       
    }
}
