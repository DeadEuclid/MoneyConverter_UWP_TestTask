using MoneyConverter.Models;
using System.Collections.Generic;

namespace MoneyConverter.Services
{
    interface ICurrensiesDataLoader
    {
        IEnumerable<Сurrency> GetСurrencies();
    }
}