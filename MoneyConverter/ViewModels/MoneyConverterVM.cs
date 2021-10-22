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
   public class MoneyConverterVM:ViewModel,ITitledVM
    {

        public string Title { get; } = "Выбор валюты";
        private double _Value1;
        public double Value1
        {
            get => _Value1;
            set
            {
                Set(ref _Value1, value);
            }
        }

        private double _Value2;
        public double Value2
        {
            get => _Value2;
            set
            {
                Set(ref _Value2, value);
            }
        }

    }
}
