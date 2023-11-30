using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class Login : User
    {
        private const int MaxAttempts = 3;

        public  void LogIn()
        {          
            List<User> allUsers = new List<User>();
            allUsers.AddRange(RegularUser.regularUsers());
            allUsers.AddRange(Admin.GetAdmins());

            int attempts = 0;           

            do
            {
                Console.WriteLine("Welcome to Syntax Squad Bank!");
                Console.WriteLine("Username: ");
                string enterUsername = Console.ReadLine();

                Console.WriteLine("Password: ");
                string enterPassword = Console.ReadLine();

                User userTryLogin = allUsers.Find(x => x.Name == enterUsername && x.Password == enterPassword);

                if (userTryLogin != null)
                {
                    Console.WriteLine("Login successful! press enter to continue to meny.");
                    Console.ReadKey();

                    if (userTryLogin.IsAdmin)
                    {
                        AdminMenu adminMenu = new AdminMenu();
                        adminMenu.ShowMenu(userTryLogin);
                        userTryLogin.IsLoggedIn = true;
                    }
                    else
                    {
                        UserMenu userMenu = new UserMenu();
                        userMenu.ShowMenu(userTryLogin);
                        IsLoggedIn = true;
                       
                    }
                    return;
                }
                else
                {
                    attempts++;
                    Console.WriteLine($"Incorrect username or password. Attempts left: {MaxAttempts - attempts}");
                }
            }while ( attempts < MaxAttempts );
            Console.WriteLine("Maximum login attempts reached. Account locked.");

            
            
        }
        public int GetUserID()
        {
            return UserId;
        }
    
    }
}
