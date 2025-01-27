using f1_app.Core;
using f1_app.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace f1_app.MVVM.ViewModel
{

    internal class MainViewModel : ObservableObject
    {
        public RelayCommand HomeViewCommand { get; set; }
       
        public RelayCommand StandingsViewCommand { get; set; }
        
        
        public StandingControlViewModel StandingVM { get; set; }

        public HomeViewModel HomeVM { get; set; }
        public ConStandingsViewModel ConStandingsVM { get; set; }
        private object _currentView;
        

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }

        }

        public MainViewModel()
        {
            ConStandingsVM = new ConStandingsViewModel();

            HomeVM = new HomeViewModel();
            
        
            StandingVM = new StandingControlViewModel();


            CurrentView = HomeVM;
            

            StandingsViewCommand = new RelayCommand(o =>
            {
                CurrentView = StandingVM;
                
            });

            HomeViewCommand = new RelayCommand(o =>
            {
                CurrentView = HomeVM;
                
            });

       

        }
    }
}
