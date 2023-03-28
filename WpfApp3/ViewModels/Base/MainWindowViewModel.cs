using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp3.ViewModels.Base
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _Title;
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
    }
}
