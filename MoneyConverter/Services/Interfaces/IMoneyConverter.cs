using MoneyConverter.Models;

namespace MoneyConverter.Services
{
    interface IMoneyConverter
    {
        double CurrencyConvert(Сurrency fromCurrency, Сurrency inCurrency, double value);
    }
}