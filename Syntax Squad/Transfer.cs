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
        private Login userID = new Login();



        /*public void WithdrawFromAccount(int fromAccountNumber, double amount, string Userpassword)
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
        }*/



        /// <summary>
        /// Metod för överföring emellan egna konton. 
        /// PIN behövs inte för egen överföring då vi loggat in en gång redan.
        /// 
        /// </summary>

        public void TransferBetweenOwnAccounts(int fromAccountNumber, int toAccountNumber, double amount, string Userpassword, User user)
        {
            Console.Clear();
            foreach (var account in BankAccount.bankAccounts)
            {
                if (account.Owner == user.Name)
                {
                    Console.WriteLine($"Account Name: {account.AccountName}");
                    Console.WriteLine($"Account number: {account.AccountNumber}");
                    Console.WriteLine($"Balance: {account.Balance} {account.Currency}");

                }
            }

            Console.WriteLine("Insert Account number to transfer from: ");
            fromAccountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert Account number to transfer to: ");
            toAccountNumber = int.Parse(Console.ReadLine());

            var fromAccount = GetBankAccount(fromAccountNumber);
            var toAccount = GetBankAccount(toAccountNumber);

            if (fromAccount.Balance < amount)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }
            fromAccount.Balance -= amount;
            toAccount.Balance += amount;

            Console.WriteLine($"Transfer successful. New balance for {fromAccount.AccountName}: {fromAccount.Balance}");
            Console.WriteLine($"New balance for {toAccount.AccountName}: {toAccount.Balance}");

        }

        /// <summary>
        /// Metod för överföring från egna konton till andra användares konton. 
        /// PIN kontroll för att säkerställa att man vill föra över till annan användare. 
        /// </summary>

        public void TransferBetweenOtherAccounts(int fromAccountNumber, int toAccountNumber, double amount, User user)
        {

            foreach (var account in BankAccount.bankAccounts)
            {
                if (account.Owner == user.Name)
                {
                    Console.WriteLine($"Account Name: {account.AccountName}");
                    Console.WriteLine($"Account number: {account.AccountNumber}");
                    Console.WriteLine($"Balance: {account.Balance} - {account.Currency}");

                }
            }

            Console.WriteLine("Insert Account number to transfer from: ");
            fromAccountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Insert Account number to transfer to: ");
            toAccountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount you wish to transfer: ");
            amount = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter your Pin code to confirm the transaction:");
            string password = Console.ReadLine();
            var fromAccount = GetBankAccount(fromAccountNumber);
            var toAccount = GetBankAccount(toAccountNumber);

            if (fromAccount == null || toAccount == null || password != userID.Password) // fungerar verkligen detta?????
            {
                Console.WriteLine("Invalid account number.");
                return;
            }

            if (fromAccount.Balance < amount)
            {
                Console.WriteLine("Insufficient funds.");
                return;
            }

            if (fromAccount != null && toAccount != null && password == userID.Password)
            {
                fromAccount.Balance -= amount;
                toAccount.Balance += amount;
                Console.WriteLine($"Transfer successful. New balance for {fromAccount.AccountName}: {fromAccount.Balance}");

            }


        }


        public BankAccount GetBankAccount(int AccountNumber)
        {
            return BankAccount.bankAccounts.Find(a => a.AccountNumber == AccountNumber);
        }



    }
}
