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
            TransferMenu transferMenu = new TransferMenu();
            CreateAccount createAccount = new CreateAccount();
            LoanMenu loanMenu = new LoanMenu();

            bool validChoice = false;
            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t---|| User Menu ||---");
                Console.WriteLine("\t1: See Accounts \n\t2: Transfer Money \n\t3: Create Account \n\t4: Loan \n\t5: Logout");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        BankAccount.ShowUserBankAccounts(user);
                        validChoice = true;
                        break;
                    case "2":
                        transferMenu.ShowMenu(user);
                        validChoice = true;
                        break;
                    case "3":
                        createAccount.MakeAccount(user);
                        validChoice = true;
                        break;
                    case "4":
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
       
    }
}
