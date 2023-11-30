using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    internal class CreateAccount
    {       
        
        private string accountName;
        private string accountType;
        private int accountNumber;
        private Login userID = new Login();
        private int userId;
        private string accountCurrency;
        private double accountBalance = 0;
        private string accountOwner;

        private BankAccount createdAccount;

        public void MakeAccount()
        {
            bool create = true;

            while (create)
            {
                AccountName();
                AccountNumber();
                AccountCurrency();
                AccountType();

                Console.Clear();
                Console.WriteLine($"\n\t {accountName} : {accountType} : {accountCurrency}" +
                    $"Are you sure this is the correct? Y/N");
                string correct = Console.ReadLine();

                if(correct.ToLower() == "y" || correct.ToLower() == "yes")
                {
                    CreateNewAccount();
                    create = false;
                }
            }
        }

        private void CreateNewAccount()
        {
            createdAccount = new BankAccount(accountName, accountType, accountNumber, accountOwner,userID.GetUserID(), accountCurrency, accountBalance);
            BankAccount.bankAccounts.Add(createdAccount);
        }

        private void GetOwner()
        {
            List<RegularUser> userList = RegularUser.regularUser;

            foreach (RegularUser user in userList)
            {
                if(user.UserId == userID.GetUserID())
                {
                    accountOwner += user.Name;
                }
            }
        }

        private string AccountCurrency()
        {
            int accCurrency;
            bool chooseCurrency = true;

            while (chooseCurrency)
            {
                Console.Clear();
                Console.WriteLine("\n\t Choose the currency for the account:" +
                    "\n 1 : SEK" +
                    "\n 2 : GBP" +
                    "\n 3 : EUR" +
                    "\n Type in the number of the currency you want.");

                if (int.TryParse(accountType, out accCurrency))
                {
                    if (accCurrency > 0 && accCurrency < 5)
                    {
                        switch (accCurrency)
                        {
                            case 1:
                                accountCurrency = "SEK";
                                return accountCurrency;
                            case 2:
                                accountCurrency = "GBP";
                                return accountCurrency;
                            case 3:
                                accountCurrency = "EUR";
                                return accountCurrency;                           
                        }
                    }
                }
                else Console.WriteLine("That is not a valid input");
            }
            return accountCurrency;
        }

        private int AccountNumber()
        {
            Random rng = new Random();
            bool getAccountNumber = true;

            while (getAccountNumber)
            {
                accountNumber = rng.Next(1000, 9999);

                foreach (BankAccount account in BankAccount.bankAccounts)
                {
                    if(account.AccountNumber != accountNumber)
                    {
                        getAccountNumber = false;
                    }
                }
            }
            return accountNumber;
        }

        private string AccountName()
        {
            bool chooseName = true;
            
            while (chooseName)
            {
                Console.Clear();
                Console.WriteLine("\n\t Write the name of the account:");
                string accName = Console.ReadLine();

                if (accName == null)
                {
                    Console.WriteLine("That is not a calid account name");
                    Console.ReadKey();
                }   else chooseName = false;
            }
            return accountName;
        }
        
        private string AccountType()
        {
            int accType;
            bool chooseType = true;
            
            while (chooseType)
            {
                Console.Clear();
                Console.WriteLine("\n\t Choose the account type:" +
                    "\n 1 : Card" +
                    "\n 2 : Savings account (2% Ränta)" +
                    "\n 3 : Investment account (4,5% Ränta)" +
                    "\n 4 : Pension" +
                    "\n Type in the number of the account you want.");

                if (int.TryParse(accountType, out accType))
                {
                    if (accType > 0 && accType < 5)
                    {
                        switch (accType)
                        {
                            case 1:
                                accountType = "Card";
                                return accountType;
                            case 2:
                                accountType = "Savings";
                                return accountType;
                            case 3:
                                accountType = "Investments";
                                return accountType;
                            case 4:
                                accountType = "Pension";
                                return accountType;
                        }
                    }
                }   else Console.WriteLine("That is not a valid input");
            }
            return accountType;
        }

    }
}
