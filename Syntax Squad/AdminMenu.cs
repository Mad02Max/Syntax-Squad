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
            bool validChoice = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t---|| Admin Menu ||---");
                Console.WriteLine("\t1: Add User \n\t2: Currency Value \n\t3: Show Users");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Admin.AddUser(user);
                        validChoice = true;
                        break;
                    case "2":
                        //currency menu
                        validChoice = true;
                        break;
                    case "3":
                        //visa alla användare kommer här
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Choose between 1, 2 or 3 please");
                        break;

                }

            } while (!validChoice);
            
            
        }
    }
}
