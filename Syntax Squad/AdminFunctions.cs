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
        /// ShowCurrentUsers function loops through AllTheUser list and prints them out
        /// </summary>
        /// <param name="user"></param>

        public static void AddUser(User user)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Add new user");
            while (true)
            {
                string newName, newPassword;

                while (true)
                {
                    Console.Write("Name of new user: ");
                    newName = Console.ReadLine();

                    Console.Write("Password: ");
                    newPassword = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(newName) && !string.IsNullOrWhiteSpace(newPassword))
                    {
                        break;
                    }
                    Console.WriteLine("Name and password cannot be empty");
                }

                Console.Write("User ID: ");
                int newUserId;

                if (!int.TryParse(Console.ReadLine(), out newUserId))
                {
                    Console.WriteLine("Invalid input, use numbers to add User ID");

                }
                else
                {
                    RegularUser newUser = new RegularUser(newName, newPassword, newUserId);
                    User.AllTheUsers.Add(newUser);
                    Console.WriteLine($"New user {newName} with ID: {newUserId} was added by {user.Name}");
                    Console.WriteLine("Do you wish to add more users? (y/n)");
                    string addMore = Console.ReadLine();

                    if (addMore.ToLower() != "y")
                    {
                        break;

                    }
                }

            }


        }
        /// <summary>
        /// Method that lets admin see wich users are in the bank
        /// </summary>
        public static void ShowCurrentUsers()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            while (true)
            {
                foreach (var user in User.AllTheUsers)
                {
                    Console.WriteLine($"User ID: {user.UserId} - User Name: {user.Name}");

                }

                Console.WriteLine("Press enter to show current users in the bank or type exit to return to menu:");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("Returning to menu..");
                    break;
                }

                
            }

        }
    }
}
