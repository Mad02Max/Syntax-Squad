using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    internal class Loan
    {
        private double toaltalMoneyAmount;
        private int accountID;
        private List<BankAccount> account = BankAccount.bankAccounts;
        private double loanSize;
        private List<Loan> loans = new List<Loan>();


        public Loan(double loanS, int accountId)
        {

            this.accountID = accountId;
            this.loanSize = loanS;

        }




        public void TakeOutLoan()
        {
            Console.Clear();
            foreach (BankAccount bankAccount in account)
            {
                if (bankAccount.ID == accountID)
                {
                    toaltalMoneyAmount += bankAccount.Balance;
                }
            }

            Console.WriteLine($"\nYou can only take out a loan that is 5 times bigger than your total balance" +
                $"\n\t Your toatal balance is {toaltalMoneyAmount}" +
                $"\n How big of a loan do you want to take?");

            double.TryParse(Console.ReadLine(), out loanSize);

            if(loanSize <= toaltalMoneyAmount * 5)
            {
                AllLoanes(loanSize, accountID);
            }else Console.WriteLine("You can not borrow that much money with the amount of money you have.");
        }

        public void SeeLoans()
        {

            Console.Clear();
            foreach (Loan loan in loans)
            {
                if (loan.accountID == accountID)
                {
                    Console.Write($"\n\t {loan}");
                }
            }

        }

        public void AllLoanes(double loanS, int accountId)
        {

            Loan loan1 = new Loan(loanS, accountId);

            loans.Add(loan1);

        }

    }
}
