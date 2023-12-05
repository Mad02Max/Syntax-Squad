namespace Syntax_Squad
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            User.ExistingUsers();

            Login login = new Login();
            login.LogIn();

            Console.ReadKey();
        }


    }
}