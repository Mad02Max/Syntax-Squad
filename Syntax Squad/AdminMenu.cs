using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
    public class AdminMenu : Menu
    {
        public override void ShowMenu(User user)
        {
            ExchangeRateManager manager = new ExchangeRateManager();
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
                        AdminFunctions.AddUser(user);
                        validChoice = true;
                        break;
                    case "2":
                        manager.ChangeExchangeRates();
                        validChoice = true;
                        break;
                    case "3":
                        AdminFunctions.ShowCurrentUsers();
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input, choose between one of the menu options");
                        break;

                }

            } while (!validChoice);
            
            
        }
    }
}
