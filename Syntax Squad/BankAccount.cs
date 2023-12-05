using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class BankAccount
    {

        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public int AccountNumber { get; set; }
        public string Owner { get; set; }
        public string Currency { get; set; }
        public double Balance { get; set; }
        public int ID { get; set; }


        public static List<BankAccount> bankAccounts = new List<BankAccount>();

        public BankAccount(string accountName, string accountType, int accountNumber, string owner,int iD, string currency, double balance)
        {
            AccountName = accountName;
            AccountType = accountType;
            AccountNumber = accountNumber;
            Owner = owner;
            Currency = currency;
            Balance = balance;
            ID = iD;
        }

        public static void ExistingBankAccounts()
        {
            BankAccount Acc1 = new BankAccount("Kontantkort","Card", 1001, "Börje",101, "SEK", 100000.743);
            BankAccount Acc2 = new BankAccount("Sparkonto","Savings", 1002, "Börje",101, "SEK", 240000.56);
            BankAccount Acc3 = new BankAccount("Gammelmans konto","Pension", 1003, "Börje",101, "SEK", 600000.40);

            BankAccount Acc4 = new BankAccount("Kreditkort","Card", 2004, "Stefan",102, "GBP", 34000.34);
            BankAccount Acc5 = new BankAccount("Sparingskonto","Savings", 2005, "Stefan",102, "GBP", 4000.34);

            BankAccount Acc6 = new BankAccount("Fun card","Card", 3006, "Åke",103, "SEK", 5600000.60);
            BankAccount Acc7 = new BankAccount("Savings fun account","Savings", 3007, "Åke",103, "SEK", 6000000.43);
            BankAccount Acc8 = new BankAccount("Rich boi","Investment", 3008, "Åke",103, "EUR", 1000000000);
            BankAccount Acc9 = new BankAccount("Old mans account","Pension", 3009, "Åke",103, "EUR", 33400.50);

            bankAccounts.Add(Acc1);
            bankAccounts.Add(Acc2); 
            bankAccounts.Add(Acc3);
            bankAccounts.Add(Acc4);
            bankAccounts.Add(Acc5); 
            bankAccounts.Add(Acc6);
            bankAccounts.Add(Acc7);
            bankAccounts.Add(Acc8);
            bankAccounts.Add(Acc9);

           
        }
        public List<BankAccount> GetList() 
        { 
            return bankAccounts; 
        }

        public void SetList(List<BankAccount> addBankAccounts)
        {
            bankAccounts = addBankAccounts;
        }
        public static void ShowUserBankAccounts(User user)
        {
            while (true)
            {
                Console.WriteLine($"--- Accounts for {user.Name} ---");

                foreach (var account in BankAccount.bankAccounts)
                {
                    if (account.Owner == user.Name)
                    {
                        Console.WriteLine($"Account Name: {account.AccountName}");
                        Console.WriteLine($"Account Type: {account.AccountType}");
                        Console.WriteLine($"Account number: {account.AccountNumber}");
                        Console.WriteLine($"Balance: {account.Balance} : {account.Currency}");
                        
                    }
                }
                Console.WriteLine("Press 'M' to return to menu ");

                string userInput = Console.ReadLine();
                if (userInput.ToUpper() != "M")
                {
                    continue;
                }
                else
                {
                    break;
                }

            }



        }
    }
}
