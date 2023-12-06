using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
    public class Admin : User
    {
        public Admin(string name, string password, int userId)
        {
            UserId = userId;
            Name = name;
            Password = password;
            IsAdmin = true;
        }
        
        





    }
}
