using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    internal class Loan
    {

        // Max SUT23

        private double loanAmount {  get; set; }
        private int accountID { get; set; }
        private int accountNumber { get; set; }

        private static double toaltalMoneyAmount;
        private static double loanSize;
        private static List<Loan> loans = new List<Loan>();
        private static Transfer getBankInfo = new Transfer();
        private static int toAcc;
        private static ExchangeRateManager exchangeRate = new ExchangeRateManager();


        /// <summary>
        /// This method checks how big of a loan the user wants and if they are eligable for it
        /// </summary>
        public static void TakeOutLoan(User user)
        {
            Console.Clear();
            toaltalMoneyAmount = 0;
            foreach (BankAccount bankAccount in BankAccount.bankAccounts)
            {
                if (bankAccount.ID == user.UserId)
                {
                    var fromRate = Convert.ToDouble(exchangeRate.exchangeRates[bankAccount.Currency]);
                    var toRate = Convert.ToDouble(exchangeRate.exchangeRates["SEK"]);
                    var convertedAmount = bankAccount.Balance * (1 / fromRate) * toRate;
                    toaltalMoneyAmount += convertedAmount;
                }
            }
            Console.WriteLine($"\nYou can only take out a loan that is 5 times bigger than your total balance" +
                $"\n\t Your toatal balance is {toaltalMoneyAmount} SEK" +
                $"\n\t And the loan will have a 4.5% intrest" +
                $"\n How big of a loan do you want to take? (SEK)");

            double.TryParse(Console.ReadLine(), out loanSize);

            if(loanSize <= toaltalMoneyAmount * 5)
            {
                List<int> accNr = getBankInfo.loggedInAccountList(user);
                Console.WriteLine("Insert Account number of the account you want the money: ");
                toAcc = int.Parse(Console.ReadLine());
                var toAccount = getBankInfo.GetBankAccount(toAcc);
                if (accNr.Contains(toAcc))
                {
                    var toRate = Convert.ToDouble(exchangeRate.exchangeRates[toAccount.Currency]);
                    var convertedLoan = loanSize * toRate;
                    toAccount.Balance += convertedLoan;
                    Console.WriteLine($"You have now taken a loan of {loanSize}");
                    AllLoanes(loanSize, user.UserId, toAcc);
                }
            }else Console.WriteLine("You can not borrow that much money with the amount of money you have.");
            Console.ReadKey();
        }

        /// <summary>
        /// Makes it so the user can see what outgoing loans they have
        /// </summary>
        public static void SeeLoans(User user)
        {
            Console.Clear();
            foreach (Loan loan in loans)
            {
                if (loan.accountID == user.UserId)
                {
                    Console.Write($"\n\t You have a loan on: {loan.loanAmount}");
                }
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Adds the new loan to a list were all loans are keept
        /// </summary>
        /// <param name="loanS"></param>
        /// <param name="accountId"></param>
        public static void AllLoanes(double loanS, int accountId, int toAcc)
        {
            Loan newLoan = new Loan
            {
                loanAmount = loanS,
                accountID = accountId,
                accountNumber = toAcc
            };
            loans.Add(newLoan);
        }

    }
}
