using MoneyConverter.Models;

namespace MoneyConverter.Services
{
    interface IMoneyConverter
    {
        double CurrencyConvert(Currency fromCurrency, Currency inCurrency, double value);
    }
}