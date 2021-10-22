using MoneyConverter.Models;
using MoneyConverter.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Markup;

namespace MoneyConverter.ViewModels
{

    class  ValuteSelect: ViewModel, ITitledVM
    {

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title { get; } = "";


        private List<Currency> _Curenies;

        public ValuteSelect()
        {
            Curenies = new List<Currency>();
            Curenies = new List<Currency>() { new Currency("RUB", "Российский рубль", 1), new Currency("RUB", "Российский рубль", 1), new Currency("RUB", "Российский рубль", 1) };
        }

        /// <summary>
        /// Список валют
        /// </summary>
        public List<Currency> Curenies
        {
            get => _Curenies;
            set
            {
                Set(ref _Curenies, value);
            }
        }
        

    }
}
