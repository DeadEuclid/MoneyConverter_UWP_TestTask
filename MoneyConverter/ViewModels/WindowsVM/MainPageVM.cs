using MoneyConverter.ViewModels.Base;
using MoneyConverter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Markup;

namespace MoneyConverter.ViewModels.WindowsVM
{

   public class MainPageVM : ViewModel

    {

        private UserControl _UC;
        public UserControl UC { get => _UC; set => Set(ref _UC, value); }
        public string Title;
        public MainPageVM()
        {

            Title = "Load";
        }

    }
}
