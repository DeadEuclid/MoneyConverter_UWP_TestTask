using MoneyConverter.Infrastucture.Comands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConverter.Infrastucture.Comands
{
    class StartLoadCurreniesComand : Command
    {
        public StartLoadCurreniesComand(Action<object> Execute, Func<object, bool> CanExecute = null) : base(Execute, CanExecute)
        {
        }
    }
}
