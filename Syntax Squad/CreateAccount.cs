using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{

    // Max SUT23

    internal class CreateAccount
    {       
        
        private string accountName;
        private string accountType;
        private int accountNumber;
        private int userId;
        private string accountCurrency;
        private double accountBalance = 0;
        private string accountOwner;

        private BankAccount createdAccount;

        /// <summary>
        /// Starts the process of creating a new bankaccount for the user so they can specify all the nesecary information.
        /// </summary>
        public void MakeAccount(User user)
        {
            bool create = true;

            while (create)
            {
                AccountName();
                AccountNumber();
                AccountCurrency();
                AccountType();
                GetOwner();

                userId = user.UserId;

                Console.Clear();
                Console.WriteLine($"\n\t {accountName} : {accountType} : {accountCurrency}" +
                    $"\n Are you sure this is the correct? Y/N");
                string correct = Console.ReadLine();

                if(correct.ToLower() == "y" || correct.ToLower() == "yes")
                {
                    CreateNewAccount();
                    create = false;
                }
            }
        }

        /// <summary>
        /// Adds the userers new bankaccount to the list with all of the nesecary information for the account provided of the user
        /// </summary>
        private void CreateNewAccount()
        {
            createdAccount = new BankAccount(accountName, accountType, accountNumber, accountOwner,userId, accountCurrency, accountBalance);
            BankAccount.bankAccounts.Add(createdAccount);
        }

        /// <summary>
        /// Gets the users name form the 
        /// </summary>
        private void GetOwner()
        {
            List<User> userList = User.AllTheUsers;

            foreach (User user in userList)
            {
                if(user.UserId == userId)
                {
                    accountOwner += user.Name;
                }
            }
        }

        /// <summary>
        /// Gives the user the choice what currency they want their bankaccount to be in
        /// </summary>
        /// <returns></returns>
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

                if (int.TryParse(Console.ReadLine(), out accCurrency))
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

        /// <summary>
        /// Sets the account number for the new account
        /// </summary>
        /// <returns></returns>
        private int AccountNumber()
        {
            Random rng = new Random();
            bool getAccountNumber = true;

            while (getAccountNumber)
            {
                accountNumber = rng.Next(1000, 9999);

                bool accountExists = BankAccount.bankAccounts.Any(account => account.AccountNumber == accountNumber);
                if (!accountExists)
                {
                    getAccountNumber = false;
                }

            }
            return accountNumber;
        }

        /// <summary>
        /// This method asks that the user input a name for their new bankaccount
        /// </summary>
        /// <returns></returns>
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
                }
                else
                {
                    accountName = accName;
                    chooseName = false;
                }
            }
            return accountName;
        }
        
        /// <summary>
        /// This methods asks the user to choose what type of account they want this bankaccount to be.
        /// </summary>
        /// <returns></returns>
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

                if (int.TryParse(Console.ReadLine(), out accType))
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
