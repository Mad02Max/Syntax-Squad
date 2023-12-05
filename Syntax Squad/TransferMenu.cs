using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
    public class TransferMenu : UserMenu
    {

        public override void ShowMenu(User user)
        {
            Transfer transfer = new Transfer();

            bool validChoice = false;
            do
            {
                
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t---|| Transfer Menu ||---");
                Console.WriteLine("\t1: Withdraw money \n\t2: Transfer between own accounts \n\t3: Transfer to another user \n\t4: Return to Main menu");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        
                        break;
                    case "2":
                        transfer.TransferBetweenOwnAccounts(user);
                        break;
                    case "3":
                        transfer.TransferBetweenOtherAccounts(user);
                        break;
                    case "4":
                        validChoice = true;
                        break;
                    default:
                        Console.WriteLine("Wrong input, choose between one of the menu options");
                        break;
                }

                Console.ReadKey();

            } while (!validChoice);
        }
    }
}
