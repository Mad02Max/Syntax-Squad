using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class Login : User           //Anton SUT23
    {
       
       private const int MaxAttempts = 3;

        public int attempts = 0;
        private int userID;     
        /// <summary>
        /// Method for login, checking user list for username and password
        /// </summary>
        public void LogIn()
        {

            UserMenu userMenu = new UserMenu();
            AdminMenu adminMenu = new AdminMenu();

            ACIIART Art = new ACIIART();

            do
            {
                Console.Clear();
                Art.PrintArt();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\tWelcome to Syntax Squad Bank!");
                Console.Write("\tUsername: ");
                string enterUsername = Console.ReadLine();

                Console.Write("\tPassword: ");
                string enterPassword = Console.ReadLine();

                User userTryLogin = AllTheUsers.Find(x => x.Name == enterUsername && x.Password == enterPassword);

                if (userTryLogin != null)
                {
                    Console.WriteLine("\tLogin successful! press enter to continue to meny.");                   
                    Console.ReadKey();
                    Console.Clear();



                    if (userTryLogin.IsAdmin)
                    {
                        adminMenu.ShowMenu(userTryLogin);
                        userTryLogin.IsLoggedIn = true;

                    }
                    else
                    {
                        userMenu.ShowMenu(userTryLogin);
                        userTryLogin.IsLoggedIn = true;

                    }
                    
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"\tIncorrect username or password. Attempts left: {MaxAttempts - attempts}");
                    Console.ReadKey();
                    Console.Clear() ;
                }
            } while (attempts < MaxAttempts);
            Console.WriteLine("\tMaximum login attempts reached. Account locked.");



        } /// <summary>
          /// Method to get user ID
          /// </summary>
        public int GetUserID()
        {
            return userID;
        }
        /// <summary>
        /// Method for reseting attempts
        /// </summary>
        public void ResetAttempt()
        {
            attempts = 0;
        }

    }
}
