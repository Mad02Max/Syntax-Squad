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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tAdd new user");
            while (true)
            {
                string newName, newPassword;

                while (true)
                {
                    Console.Write("\tName of new user: ");
                    newName = Console.ReadLine();

                    Console.Write("\tPassword: ");
                    newPassword = Console.ReadLine();

                    if (!string.IsNullOrWhiteSpace(newName) && !string.IsNullOrWhiteSpace(newPassword))
                    {
                        break;
                    }
                    Console.WriteLine("\tName and password cannot be empty");
                }

                Console.Write("\tUser ID: ");
                int newUserId;

                if (!int.TryParse(Console.ReadLine(), out newUserId))
                {
                    Console.WriteLine("\tInvalid input, use numbers to add User ID");

                }
                else
                {
                    RegularUser newUser = new RegularUser(newName, newPassword, newUserId);
                    User.AllTheUsers.Add(newUser);
                    Console.WriteLine($"\tNew user {newName} with ID: {newUserId} was added by {user.Name}");
                    Console.WriteLine("\tDo you wish to add more users? (y/n)");
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
                    Console.WriteLine($"\tUser ID: {user.UserId} - User Name: {user.Name}");

                }

                Console.WriteLine("\tPress enter to show current users in the bank or type exit to return to menu:");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    Console.WriteLine("\tReturning to menu..");
                    break;
                }

                
            }


        }
        /// <summary>
        /// Method that lets admin remove users
        /// </summary>
        public static void RemoveUser()
        {
            Console.ForegroundColor= ConsoleColor.Green;
            Console.WriteLine("Remove User");

            {
                while (true)
                {
                    Console.Write("Enter User ID to remove: ");
                    int userIdRemove;

                    if(!int.TryParse(Console.ReadLine(), out userIdRemove))
                    {
                        Console.WriteLine("Invalid input. Please enter a valid User ID");
                    }
                    else
                    {
                        User userToRemove = User.AllTheUsers.FirstOrDefault(x => x.UserId == userIdRemove);

                        if (userToRemove != null)
                        {
                            User.AllTheUsers.Remove(userToRemove);
                            Console.WriteLine($"User with ID {userIdRemove} removed successfully!");
                        }
                        else
                        {
                            Console.WriteLine($"User with ID {userIdRemove} not found.");
                        }
                        Console.WriteLine("Do you wish to remove more users? Y/N");
                        string removeMore = Console.ReadLine();

                        if (removeMore.ToLower() != "y")
                        {
                            break;
                        }
                    }
                }
            }
        }

       
    }
}
