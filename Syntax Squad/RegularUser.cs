using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
    public class RegularUser : User
    {
        public RegularUser(string name, string password, int userId)
        {
            UserId = userId;
            Name = name;
            Password = password;
        }
        
    }


}

