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
            CreateAccount newAccount = new CreateAccount();
            LoanMenu loanMenu = new LoanMenu();
            SettingsMenu settingsMenu = new SettingsMenu();
            ACIIART Art = new ACIIART();
            Console.ForegroundColor = ConsoleColor.Yellow;

            bool validChoice = true;
            do
            {
                Console.Clear();
                Art.PrintArt();
                Console.WriteLine("\t---|| User Menu ||---");
                Console.WriteLine("\t1: See Accounts \n\t2: Transfer Money \n\t3: Create Account \n\t4: Loan \n\t5: Settings \n\t6: Logout");

                string userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        BankAccount.ShowUserBankAccounts(user);
                        break;
                    case "2":
                        transferMenu.ShowMenu(user);
                        break;
                    case "3":
                        newAccount.MakeAccount(user);
                        break;
                    case "4":
                        loanMenu.ShowMenu(user);
                        break;
                    case "5":
                        settingsMenu.ShowMenu(user);
                        break;
                    case "6":
                        user.IsLoggedIn = false;
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
