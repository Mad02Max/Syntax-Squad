using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class UserMenu : Menu
    {
        public override void ShowMenu(User user)
        {
            bool validChoice = false;
            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t---|| User Menu ||---");
                Console.WriteLine("\t1: See Accounts \n\t2: Transfer Money \n\t3: Create Account \n\t4: Loan \n\t5: Logout");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowUserAccounts(user);
                        validChoice = true;
                        break;
                    case "2":

                        validChoice = true;
                        break;
                    case "3":
                        CreateAccount createAccount = new CreateAccount();
                        createAccount.MakeAccount();
                        validChoice = true;
                        break;
                    case "4":


                        validChoice = true;
                        break;
                    case "5":
                        break;
                    default:
                        break;


                }

            } while (!validChoice);
        }
        private static void ShowUserAccounts(User user)
        {
            while (true)
            {
                Console.WriteLine($"--- Accounts for {user.Name} ---");

                foreach (var account in BankAccount.bankAccounts)
                {
                    if (account.Owner == user.Name)
                    {
                        Console.WriteLine($"Account Name: {account.AccountName}");
                        Console.WriteLine($"Account Type: {account.AccountType}");
                        Console.WriteLine($"Account number: {account.AccountNumber}");
                        Console.WriteLine($"Currency: {account.Currency}");
                        Console.WriteLine($"Balance: {account.Balance}");
                    }
                }
                Console.WriteLine("Press 'M' to return to menu ");

                string userInput = Console.ReadLine();
                if (userInput.ToUpper() != "M")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }



        }
    }
}
