using f1_app.Core;
using f1_app.MVVM.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace f1_app.MVVM.ViewModel
{
    class StandingControlViewModel : ObservableObject
    {
        private object _controlCurrentView;

        public RelayCommand DriverGridCommand {  get; set; }
        public RelayCommand ConGridCommand { get; set; }
        public DriverStandingViewModel DriverVM { get; set; }
        public ConStandingsViewModel ConVM { get; set; }


        public object ControlCurrentView
        {
            get { return _controlCurrentView; }
            set
            {
                _controlCurrentView = value;
                OnPropertyChanged();
            }

        }

        public StandingControlViewModel() {
            DriverVM = new DriverStandingViewModel();
            ConVM = new ConStandingsViewModel();

            ControlCurrentView = ConVM;

            DriverGridCommand = new RelayCommand(o =>
            {
                ControlCurrentView = DriverVM;

            });

            ConGridCommand = new RelayCommand(o =>
            {

                ControlCurrentView = ConVM;


            });
        }
    }





    

    
    
}
