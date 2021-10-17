using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;


namespace MoneyConverter.Infrastucture.Comands.Base
{
     class Command : ICommand
    {
        private readonly Action<object> _Execute;
        private readonly Func<object, bool> _CanExecute;

        public Command(Action<object> Execute, Func<object, bool> CanExecute = null)
        {

            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public event EventHandler CanExecuteChanged;
 

        public  bool CanExecute(object parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public  void Execute(object parameter)
        {
            if (!CanExecute(parameter)) return;
            _Execute(parameter);
        }

    }
}
