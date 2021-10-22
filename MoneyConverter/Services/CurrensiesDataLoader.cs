﻿using MoneyConverter.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter.Services
{
    class CurrensiesDataLoader : ICurrensiesDataLoader
    {
        private HttpClient _client;
        CurrensiesDataLoader()
        {

        }
        public IEnumerable<Сurrency> GetСurrencies()
        {
            _client.BaseAddress =new Uri("https://www.cbr-xml-daily.ru/");
            _client.GetAsync("/daily_json.js");
            throw new NotImplementedException();
        }
    }
}
