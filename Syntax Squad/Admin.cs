using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class Admin : User
    {
        public static List<Admin> Admins = new List<Admin>();
        public Admin(string name, string password, int userId)
        {
            UserId = userId;
            Name = name;
            Password = password;
            IsAdmin = true;

        }
        public static void ExistingAdmins()
        {
            Admins.Add(new Admin("Syntax", "Squad", 1337));
        }
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
                    RegularUser.regularUsers.Add(newUser);

                    Console.WriteLine($"New user {newName} was added by {user.Name}");

                    Console.WriteLine("Do you wish to add more users? (y/n)");
                    string addMore = Console.ReadLine();

                    if(addMore.ToLower() != "y")
                    {
                        break;
                    }

                }

            } while (true);


        }





    }
}
