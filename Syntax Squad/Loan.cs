using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    internal class Loan
    {

        // Max SUT23

        private double loanAmount {  get; set; }
        private int accountID { get; set; }

        private double toaltalMoneyAmount;
        private Login userID = new Login();
        private int userId;
        private double loanSize;
        private List<Loan> loans = new List<Loan>();
        

        /// <summary>
        /// This method checks how big of a loan the user wants and if they are eligable for it
        /// </summary>
        public void TakeOutLoan(User user)
        {
            Console.Clear();
            foreach (BankAccount bankAccount in BankAccount.bankAccounts)
            {
                if (bankAccount.ID == user.UserId)
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
                AllLoanes(loanSize, user.UserId);
            }else Console.WriteLine("You can not borrow that much money with the amount of money you have.");
        }

        /// <summary>
        /// Makes it so the user can see what outgoing loans they have
        /// </summary>
        public void SeeLoans(User user)
        {
            Console.Clear();
            foreach (Loan loan in loans)
            {
                if (loan.accountID == user.UserId)
                {
                    Console.Write($"\n\t You have a loan on: {loan.loanAmount}");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Adds the new loan to a list were all loans are keept
        /// </summary>
        /// <param name="loanS"></param>
        /// <param name="accountId"></param>
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
