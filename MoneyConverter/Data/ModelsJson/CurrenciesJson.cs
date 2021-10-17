using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter.Data.ModelsJson
{
    public struct CurrenciesJson
    {
        public Dictionary<string, CurrencyJson> Valute { get; set; }
    }

}
