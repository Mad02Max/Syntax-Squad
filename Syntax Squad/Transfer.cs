using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class Transfer
    {
        //Simon Ståhl SUT23
        private List<BankAccount> transferAccounts = BankAccount.bankAccounts;
        private List<Login> TransferPWList = Login.allUsers;
        

                
        public void WithdrawFromAccount(int fromAccountNumber, double amount, string Userpassword)
        {

            var fromAccount = GetBankAccount(fromAccountNumber);
            if (fromAccount.Balance == null || fromAccount.Balance < 0 && password == Userpassword)
            {
                Console.WriteLine("Insufficient fund on selected Account.");
                return;
            }
            fromAccount.Balance = amount;

            Console.WriteLine($"Withdraw request successfull. Please take your money.");
            Console.WriteLine($"Remaining Balance for {fromAccount}: {fromAccount.Balance}");
        }


        /// <summary>
        /// Metod för överföring emellan egna konton. 
        /// PIN behövs inte för egen överföring då vi loggat in en gång redan.
        /// 
        /// </summary>
        
        public void TransferBetweenOwnAccounts(int fromAccountNumber, int toAccountNumber, double amount, string Userpassword)
        {
            var fromAccount = GetBankAccount(fromAccountNumber);
            var toAccount = GetBankAccount(toAccountNumber);

            if (fromAccount.Balance < amount )
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }
            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            Console.WriteLine($"Transfer successful. New balance for {fromAccountNumber}: {fromAccount.Balance}");
            Console.WriteLine($"New balance for {toAccountNumber}: {toAccount.Balance}");

        }

        /// <summary>
        /// Metod för överföring från egna konton till andra användares konton. 
        /// PIN kontroll för att säkerställa att man vill föra över till annan användare. 
        /// </summary>
       
        public void TransferBetweenOtherAccounts(int fromAccountNumber, int toAccountNumber, double amount, string Userpassword)
        {
            var fromAccount = GetBankAccount(fromAccountNumber);
            var toAccount = GetBankAccount(toAccountNumber);
            string password;

            if (fromAccount == null || toAccount == null && password == Userpassword)
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            if (fromAccount.Balance < amount)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            Console.WriteLine($"Transfer successful. New balance for {fromAccountNumber}: {fromAccount.Balance:C}");
            

        }

        public BankAccount GetBankAccount(int AccountNumber)
        {
            return BankAccount.bankAccounts.Find(a => a.AccountNumber == AccountNumber);
        }
               
    }
}
