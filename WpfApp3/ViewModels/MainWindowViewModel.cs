using OxyPlot;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WpfApp3.Infrastructure.Commands;
using WpfApp3.ViewModels.Base;
    

namespace WpfApp3.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private int selectedPageIndex;
        public int SelectedPageIndex
        {
            get => selectedPageIndex;
            set => Set(ref selectedPageIndex, value);
        }
        #region TestDataPoint : IEnumerable<DataPoint> - Тест набор данных для визуализации
        private IEnumerable<DataPoint> testDataPoints;
        public  IEnumerable<DataPoint> TestDataPoints
        {
            get => testDataPoints;
            set => Set(ref testDataPoints, value);
        }
        #endregion
        private string _Title;
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #region Status : string - Статус программы
        private string _Status = "Готов!";
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }
        #endregion
        #region Команды
        public ICommand CloseApplicationCommand { get; }

        private bool CanCloseApplicationCommandExecuted(object p) => true;

        private void OnCloseApplicationCommandExecute(object p)
        {
            Application.Current.Shutdown();

        }
        #endregion

        public ICommand ChangeTabIndexCommand { get; }
        private bool CanChangeTabIndexCommandExecute(object p) => selectedPageIndex >=0;
        private void OnChangeTabIndexCommandExecute(object p)
        {
            if (p is null) return;
            SelectedPageIndex += Convert.ToInt32(p);
        }


        public MainWindowViewModel()
        {
            #region Команды
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecuted);
            ChangeTabIndexCommand = new LambdaCommand(OnChangeTabIndexCommandExecute, CanChangeTabIndexCommandExecute);

            #endregion
            var data_points =   new List<DataPoint>((int)(360/0.1));
            for(var x=0d; x <= 360; x += 0.1)
            {
                const double to_rad = Math.PI / 180;
                var y  = Math.Sin(2* Math.PI * x * to_rad);
                data_points.Add(new DataPoint(x,y   ));
            }
            
            TestDataPoints = data_points;
            

        }

    }
}
