using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter.Models
{
    public struct Сurrency
    {
        public Сurrency(string code, string name, decimal rubPerUnit)
        {
            Code = code;
            Name = name;
            RubPerUnit = rubPerUnit;
        }

        public string Code { get; }
        public string Name { get; }
        public decimal RubPerUnit{get;}

    }
}
