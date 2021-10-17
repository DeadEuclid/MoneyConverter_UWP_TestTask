using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyConverter.Models;

namespace MoneyConverter.Services
{
    class MoneyConverter : IMoneyConverter
    {
        public double CurrencyConvert(Currency fromCurrency, Currency inCurrency, double value) => (fromCurrency.RubPerUnit * value) / inCurrency.RubPerUnit;
    }
}
