using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23

    public class UserFunctions
    {
        /// <summary>
        /// Method that lets user set transfer limit amount
        /// </summary>
        /// <param name="user"></param>
        public static void SetTransferLimit(User user)
        {
            Console.Clear();
            double maxTransfer;
            bool isValidInput;
            Console.WriteLine("\tSet transfer limit");
            do
            {
                Console.Write("\tWich amount would you like as your maximum transfer amount: ");
                string input = Console.ReadLine();
                isValidInput = double.TryParse(input, out maxTransfer);

                if (isValidInput)
                {
                    user.TransferLimit = maxTransfer;
                    Console.WriteLine($"\tYour new transfer limit is: {user.TransferLimit}");
                }
                else
                {
                    Console.WriteLine("\tInvalid input, enter valid number please");
                }

            } while (!isValidInput);
            Console.WriteLine("\tPress enter to return to settings");
            Console.ReadKey();
        }
        /// <summary>
        /// Method that lets the user change password
        /// </summary>
        /// <param name="user"></param>
        public static void ChangePassword(User user)
        {
            Console.Clear();
            Console.WriteLine("\tChange password");
            Console.WriteLine($"\tYour current password is: {user.Password}");
            Console.Write("\tWhat would you like your new password to be? ");

            string newPassword = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(newPassword))
            {
                Console.WriteLine("\tInvalid input, try again..");
            }
            else
            {
                user.Password = newPassword;
                Console.WriteLine($"\tYour new password is: {user.Password}");

            }
            Console.WriteLine("\tPress enter to return to settings");
            Console.ReadKey();
        }
        /// <summary>
        /// Method that lets user close bank account of their choice
        /// </summary>
        /// <param name="user"></param>
        public static void CloseAccount(User user)
        {
            Console.Clear();
            Console.WriteLine("\n\tYour current bank accounts:");
            foreach (var account in BankAccount.bankAccounts)
            {
                if (account.Owner == user.Name)
                {
                    Console.Write($"\tAccount Name: {account.AccountName}");
                    Console.Write($"\tAccount Type: {account.AccountType}");
                    Console.WriteLine($"\tAccount number: {account.AccountNumber}");
                    Console.WriteLine($"\tBalance: {account.Balance} : {account.Currency}");
                }
            }
            Console.WriteLine("\tWould like to close one of your accounts? y/n?");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "y")
            {
                Console.WriteLine("\tType accountnumber of the account you wish to close");
                int removeAccountNumber = Convert.ToInt32(Console.ReadLine());
                BankAccount removeAccount = BankAccount.bankAccounts.Find(x => x.AccountNumber == removeAccountNumber);
                if (removeAccount != null)
                {
                    if (removeAccount.Balance == 0)
                    {
                        BankAccount.bankAccounts.Remove(removeAccount);
                        Console.WriteLine($"\tAccount {removeAccountNumber} has been closed");
                    }
                    else
                    {
                        Console.WriteLine($"\tAccount {removeAccountNumber} cannot be closed at the moment");
                    }

                }
                else
                {
                    Console.WriteLine($"\tAccount with number {removeAccountNumber} not found.");
                }

            }
            else
            {
                Console.WriteLine("\tNo accounts were closed.");
            }
            Console.WriteLine("\tPress enter to return to menu");
            Console.ReadKey();
        }
    }
}
