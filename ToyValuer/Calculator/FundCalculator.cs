using ToyValuer.DataAccess;

namespace ToyValuer.Calculator
{
    public class FundCalculator
    {
        private readonly BalancesRepository _balancesRepository;
        private readonly PricesRepository _pricesRepository;

        public FundCalculator(BalancesRepository balancesRepository, PricesRepository pricesRepository)
        {
            _balancesRepository = balancesRepository;
            _pricesRepository = pricesRepository;
        }

        // Real Funds
        public decimal CalculateFundValue(string fund)
        {
            // Access DB to get balances of this fund on this date
            var balances = new Dictionary<string, decimal>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "AAPL", 10 },
                { "GOOGL", 20 },
                { "MSFT", 10 }
            };
            // Access DB to get prices of all holdings on this date
            var prices = new Dictionary<string, decimal>(StringComparer.InvariantCultureIgnoreCase)
            {
                { "AAPL", 100 },
                { "GOOGL", 200 },
                { "MSFT", 300 }
            };
            // Sum up all holdings * prices of each holding
            var total = 0m;
            foreach(var balance in balances)
            {
                if (prices.TryGetValue(balance.Key, out var price))
                {
                    total += balance.Value * price;
                }
            }
            return total;
        }

        // Fund of Funds
        public decimal CalculateFundOfFundsValue(string fundOfFunds)
        { 
            return 0m;
        }

        // MPC Folios
        public decimal CalculateMPCFolios(string mpcFolio)
        {
            return 0m;
        }

        // Add test suite
    }
}
