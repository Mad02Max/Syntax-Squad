using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    internal class CreateAccount
    {

        public string accountType;

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

                }else Console.WriteLine("That is not a valid input");
            }


            return accountType;
        }

    }
}
