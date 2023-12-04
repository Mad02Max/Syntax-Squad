using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class ExchangeRateManager
    {
        //Simon Ståhl SUT23
        public Dictionary<string, decimal> exchangeRates;

        public ExchangeRateManager()
        {
            exchangeRates = new Dictionary<string, decimal>
            {
                {"GBP", 0.076m},
                {"EUR", 0.088m},
                {"SEK", 1.00m},
            };
        }

        public void ChangeExchangeRates(string currencyCode, decimal newRate)
        {
            if (exchangeRates.ContainsKey(currencyCode))
            {
                exchangeRates[currencyCode] = newRate;
                Console.WriteLine($"Exchange rate for {currencyCode} has been changed to {newRate}");
            }
            else
            {
                Console.WriteLine($"Currency {currencyCode} was not found in the system.");
            }
        }

        public void DisplayExhangeRates()
        {
            Console.WriteLine("Currencies to choose from:");
            foreach (var rate in exchangeRates)
            {
                Console.WriteLine($"{rate.Key}: {rate.Value}");
            }
        }
                
    }
}
