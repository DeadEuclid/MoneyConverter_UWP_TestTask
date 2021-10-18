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
    [MarkupExtensionReturnType()]
    class MainPageVM : ViewModel
    {
        public ViewModel ViewModel;



        private object _View;
        /// <summary>
        /// Отображаемый UserControl
        /// </summary>
        public object View
        {
            get => _View;
            set
            {
                Set(ref _View, value);

            }
        }

        private string _Title;
        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title
        {
            get => _Title;
            set
            {
                Set(ref _Title, value);
                ApplicationView appView = ApplicationView.GetForCurrentView();
                appView.Title = "Title text goes here";
            }
        }
        public MainPageVM()
        {
            ViewModel = new MoneyConverterVM(OnChangeValute);
        }

        public MainPageVM(object view, string title)
        {
            View =new LoadingView();
            Title = "Load";
        }

        private void OnChangeValute()
        {
            View = new LoadingView();
        }
    }
}
