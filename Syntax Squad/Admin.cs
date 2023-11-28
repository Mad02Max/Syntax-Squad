using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class Admin : User
    {

        public Admin(string name, string password)
        {
            Name = name;
            Password = password;
            IsAdmin = true;

        }
        public static List<Admin> GetAdmins()
        {
            var admins = new List<Admin>();
            admins.Add(new Admin("Syntax", "Squad"));

            return admins;

        }





    }
}
