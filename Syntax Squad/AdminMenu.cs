using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class AdminMenu : Menu
    {
        public override void ShowMenu(User user)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t---|| Admin Menu ||---");
            Console.WriteLine("\t1: Add User \n\t2: Currency Value \n\t3: Show Users");


        }
    }
}
