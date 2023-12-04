using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
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
                        ShowUserBankAccounts(user);
                        validChoice = true;
                        break;
                    case "2":
                        TransferMenu transferMenu = new TransferMenu();
                        transferMenu.ShowMenu(user);
                        validChoice = true;
                        break;
                    case "3":
                        CreateAccount createAccount = new CreateAccount();
                        createAccount.MakeAccount();
                        validChoice = true;
                        break;
                    case "4":
                        LoanMenu loanMenu = new LoanMenu();
                        loanMenu.ShowMenu(user);
                        validChoice = true;
                        break;
                    case "5":
                        //logout metod kommer här
                        break;
                    default:
                        Console.WriteLine("Wrong input, choose between one of the menu options");
                        break;


                }

            } while (!validChoice);
        }
        private static void ShowUserBankAccounts(User user)
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
