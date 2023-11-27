using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syntax_Squad
{
    public class ExchangeRateManager
    {

        private Dictionary<string, decimal> exchangeRates;

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
                Console.WriteLine($"Växelkurs för {currencyCode} har ändrats till {newRate}");
            }
            else
            {
                Console.WriteLine($"Valutan {currencyCode} finns inte med i systemet");
            }
        }

        public void DisplayExhangeRates()
        {
            Console.WriteLine("Aktuella Valutor att välja emellan:");
            foreach (var rate in exchangeRates)
            {
                Console.WriteLine($"{rate.Key}: {rate.Value}");
            }
        }
                
    }
}
