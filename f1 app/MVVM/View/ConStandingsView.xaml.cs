using f1_app.MVVM.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace f1_app.MVVM.View
{
    /// <summary>
    /// Interaction logic for ConStandingsView.xaml
    /// </summary>
    public partial class ConStandingsView : UserControl
    {
        private ConStandingsViewModel _viewModel;
        public ConStandingsView()
        {
            InitializeComponent();
            _viewModel = new ConStandingsViewModel();
            DataContext = _viewModel;
            

        }

    
    }
}
