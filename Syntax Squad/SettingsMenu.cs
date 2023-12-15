using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
    public class SettingsMenu : Menu
    {
        public override void ShowMenu(User user)
        {
            ACIIART Art = new ACIIART();
            Console.ForegroundColor = ConsoleColor.Yellow;

            bool validChoice = true;
            do
            {
                Console.Clear();
                Art.PrintArt();

                Console.WriteLine("\t---|| Settings ||---");
                Console.WriteLine("\t1: Set transfer limit \n\t2: Change password \n\t3: Close Account \n\t4: Return to menu");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        UserFunctions.SetTransferLimit(user);
                        break;
                    case "2":
                        UserFunctions.ChangePassword(user);
                        break;
                    case "3":
                        UserFunctions.CloseAccount(user);
                        break;
                    case "4":
                        validChoice = false;
                        break;
                    default:
                        break;
                }


            } while (validChoice);

        }
    }
}
