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

  public  class LoadingVM : ViewModel, ITitledVM
    {

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title { get; } = "";


        

    }
}
