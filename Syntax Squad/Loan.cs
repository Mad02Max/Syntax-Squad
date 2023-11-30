using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    internal class Loan
    {

        private double loanAmount {  get; set; }
        private int accountID { get; set; }

        private double toaltalMoneyAmount;
        private Login userID = new Login();
        private List<BankAccount> account = BankAccount.bankAccounts;
        private double loanSize;
        private List<Loan> loans = new List<Loan>();

        public void TakeOutLoan()
        {
            Console.Clear();
            foreach (BankAccount bankAccount in account)
            {
                if (bankAccount.ID == userID.UserId)
                {
                    toaltalMoneyAmount += bankAccount.Balance;
                }
            }

            Console.WriteLine($"\nYou can only take out a loan that is 5 times bigger than your total balance" +
                $"\n\t Your toatal balance is {toaltalMoneyAmount}" +
                $"\n\t And the loan will have a 4.5% intrest" +
                $"\n How big of a loan do you want to take?");

            double.TryParse(Console.ReadLine(), out loanSize);

            if(loanSize <= toaltalMoneyAmount * 5)
            {
                AllLoanes(loanSize, userID.UserId);
            }else Console.WriteLine("You can not borrow that much money with the amount of money you have.");
        }

        public void SeeLoans()
        {

            Console.Clear();
            foreach (Loan loan in loans)
            {
                if (loan.accountID == userID.GetUserID())
                {
                    Console.Write($"\n\t You have a loan on: {loan.loanAmount}");
                }
            }

        }

        public void AllLoanes(double loanS, int accountId)
        {

            Loan newLoan = new Loan
            {
                loanAmount = loanS,
                accountID = accountId
            };
            loans.Add(newLoan);

        }

    }
}
