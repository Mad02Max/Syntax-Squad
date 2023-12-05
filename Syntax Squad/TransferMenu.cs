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

            bool validChoice = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("---|| Transfer Menu ||---");
                Console.WriteLine("\t1: Withdraw money \n\t2: Transfer between own accounts \n\t3: Transfer to another user");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":

                        break;
                    case "2":

                        break;
                    case "3":

                    default:
                        Console.WriteLine("Wrong input, choose between one of the menu options");
                        break;
                }

                Console.ReadKey();

            } while (!validChoice);
        }
    }
}
