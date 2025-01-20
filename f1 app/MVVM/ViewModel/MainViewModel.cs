using f1_app.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_app.MVVM.ViewModel
{
    
    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand DriverStandingViewCommand { get; set; }
        public RelayCommand StandingsViewCommand { get; set; }
        public ConStandingsViewModel StandingVM { get; set; }
        public ControlsViewModel ControlsVM { get; set; }
        public DriverStandingViewModel DriverStandingVM { get; set; }
        public HomeViewModel HomeVM { get; set; }
        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set { _currentView = value;
                OnPropertyChanged();
            }
            
        }

        public MainViewModel()
        {

            StandingVM = new ConStandingsViewModel();
            HomeVM = new HomeViewModel();
            DriverStandingVM = new DriverStandingViewModel();
            ControlsViewModel ControlsVM = new ControlsViewModel();
            CurrentView = ControlsVM;

            StandingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = StandingVM;
            });

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
            });

            DriverStandingViewCommand = new RelayCommand(o =>
            {
                CurrentView = DriverStandingVM;
            });
        }

    }
}
