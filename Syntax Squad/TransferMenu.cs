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
        Transfer transfer = new Transfer();
        public override void ShowMenu(User user)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            ACIIART Art = new ACIIART();

            bool validChoice = true;
            do
            {
                Console.Clear();
                Art.PrintArt();
                Console.WriteLine("\t---|| Transfer Menu ||---");
                Console.WriteLine("\t1: Transfer between own accounts  \n\t2: Transfer to another user \n\t3: Transaction history \n\t4: Return to menu");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        transfer.TransferBetweenOwnAccounts(user);
                        break;
                    case "2":
                        transfer.TransferBetweenOtherAccounts(user);
                        break;
                    case "3":
                        Transfer.PrintTransactionHistoryUser(user);
                        break;
                    case "4":
                        validChoice = false;
                        break;
                    default:
                        Console.WriteLine("Wrong input, choose between one of the menu options");
                        break;
                }



            } while (validChoice);
        }
    }
}
