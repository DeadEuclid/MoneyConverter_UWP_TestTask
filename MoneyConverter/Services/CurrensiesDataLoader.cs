using MoneyConverter.Models;
using MoneyConverter.Data.ModelsJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MoneyConverter.Services
{
    public class CurrensiesDataLoader : ICurrensiesDataLoader
    {
        private HttpClient _client = new HttpClient();
        public CurrensiesDataLoader()
        {

        }
        public async Task<IEnumerable<Currency>> GetСurrenciesAsync()
        {
            _client.BaseAddress = new Uri("https://www.cbr-xml-daily.ru");

            var respounse = await _client.GetAsync("/daily_json.js");
            var rawJson = await respounse.Content.ReadAsStringAsync();
             var resultDictionary= JsonSerializer.Deserialize<CurrenciesJson>(rawJson);
            List<Currency> result = new List<Currency>();
            foreach (var currensy in resultDictionary.Valute.Values)
            {
                result.Add(new Currency(currensy.CharCode, currensy.Name, currensy.Value / currensy.Nominal));
            }
                return result;

        }
    }
}
