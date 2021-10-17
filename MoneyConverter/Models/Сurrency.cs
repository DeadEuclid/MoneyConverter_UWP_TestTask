using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter.Models
{
    public struct Сurrency
    {
        public Сurrency(string code, string name, double rubPerUnit)
        {
            Code = code;
            Name = name;
            RubPerUnit = rubPerUnit;
        }

        public string Code { get; }
        public string Name { get; }
        public double RubPerUnit{get;}

    }
}
