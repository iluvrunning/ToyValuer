using Microsoft.Extensions.Options;
using ToyValuer.DataAccess.DTOs;

namespace ToyValuer.DataAccess
{
    public class BalancesRepository
    {
        private readonly string _connectionString;
        
        public BalancesRepository(IOptions<ConnectionStrings> connectionStrings)
        {
            _connectionString = connectionStrings.Value.SqlDefaultConnection;

        }
        public IEnumerable<BalanceDto> GetBalancesForFolio(string folio)
        {

            return new List<BalanceDto>();
        }
    }

}
