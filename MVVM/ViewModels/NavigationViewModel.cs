using MVVM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using static MVVM.ViewModels.BaseViewModel;

namespace MVVM.ViewModels
{
    public class NavigationViewModel : BaseViewModel
    {
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value; OnPropertyChanged(); }
        }
        public ICommand InputCommand { get; set; }
        public ICommand StatusCommand { get; set; }

        private void Input(object obj) => CurrentView = new InputViewModel();
        private void Status(object obj) => CurrentView = new StatusViewModel();
        public NavigationViewModel()
        {
            InputCommand = new RelayCommand(Input);
            StatusCommand = new RelayCommand(Status);
            //Startup Page
            CurrentView = new InputViewModel();
        }
    }
}
