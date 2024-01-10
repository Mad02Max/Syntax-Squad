using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public static class Bank
    {
        public static void Start()
        {
            User.ExistingUsers();
            BankAccount.ExistingBankAccounts();

            Login login = new Login();
            login.LogIn();
        }
    }
}
