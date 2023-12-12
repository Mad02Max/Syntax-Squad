using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class UserFunctions
    {
        public static void SetTransferLimit(User user)
        {
            double maxTransfer;
            bool isValidInput;
            Console.WriteLine("\tSet transfer limit");
            do
            {
                Console.WriteLine("\tWich amount would you want to set as your maximum transfer amount");
                string input = Console.ReadLine();
                isValidInput = double.TryParse(input, out maxTransfer);
                
                if (isValidInput)
                {
                    user.TransferLimit = maxTransfer;
                    Console.WriteLine($"\tYour new transfer limit is {user.TransferLimit}");
                }
                else
                {
                    Console.WriteLine("\tInvalid input, enter valid number please");
                }

            }while(!isValidInput);

            Console.ReadKey();
        }
        public static void ChangePassword(User user) 
        {
            Console.WriteLine("\tPassword change");

        }
    }
}
