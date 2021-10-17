using MoneyConverter.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MoneyConverter.Services
{
    interface ICurrensiesDataLoader
    {
        Task<IEnumerable<Currency>> GetСurrenciesAsync();
    }
}