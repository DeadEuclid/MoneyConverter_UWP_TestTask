using MoneyConverter.Infrastucture.Comands.Base;
using MoneyConverter.ViewModels.Base;
using MoneyConverter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MoneyConverter.ViewModels
{
    class MoneyConverterVM:ViewModel
    {
        MoneyConverterVM()
        {
            View = new ValuteSelectView();
        }
        public string Title { get; }
        public UserControl View { get; private set; }
        public Command ChangeValuteCommand = new Command(OnChangeValute);

        public MoneyConverterVM(changeValuteHandler changeValute)
        {
            ChangeValute += changeValute;
        }

        public event changeValuteHandler ChangeValute;
        public delegate void changeValuteHandler();
private static void OnChangeValute(object obj)
        {


        }
    }
}
