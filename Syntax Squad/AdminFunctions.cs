using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    //Noah SUT23
    public class AdminFunctions
    {
        /// <summary>
        /// AddUser function makes it possible for admins to add more users in the program
        /// </summary>
        /// <param name="user"></param>
        public static void AddUser(User user)
        {
            Console.WriteLine("Add new user");
            do
            {
                Console.Write("Name of new user: ");
                string newName = Console.ReadLine();

                Console.Write("Password: ");
                string newPassword = Console.ReadLine();

                Console.Write("User ID: ");
                int newUserId;

                while (!int.TryParse(Console.ReadLine(), out newUserId))
                {
                    Console.WriteLine("Invalid input, has to be valid integer for user ID");
                    Console.WriteLine("User ID: ");
                }


                if (string.IsNullOrWhiteSpace(newName) || string.IsNullOrWhiteSpace(newPassword))
                {
                    Console.WriteLine("Name and password cannot be empty");
                }
                else
                {

                    RegularUser newUser = new RegularUser(newName, newPassword, newUserId);
                    RegularUser.AllTheUsers.Add(newUser);

                    Console.WriteLine($"New user {newName} was added by {user.Name}");

                    Console.WriteLine("Do you wish to add more users? (y/n)");
                    string addMore = Console.ReadLine();

                    if (addMore.ToLower() != "y")
                    {

                        break;
                    }

                }

            } while (true);


        }
        /// <summary>
        /// Method that lets admin see wich users are in the bank
        /// </summary>
        public static void ShowCurrentUsers()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                Console.WriteLine("Press enter to show current users in the bank or type exit to return to menu:");
                string userInput = Console.ReadLine();

                if(userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Returning to menu..");
                    break;
                }

                foreach (var user in RegularUser.AllTheUsers)
                {
                    Console.WriteLine($"{user.UserId} - {user.Name}");

                }
                
            }
            

        }
    }
}
