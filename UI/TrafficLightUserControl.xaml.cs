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

namespace UI
{
    /// <summary>
    /// Interaction logic for TrafficLight.xaml
    /// </summary>
    public partial class TrafficLightUserControl : UserControl
    {
        //TrafficLightUserControlViewModel _viewModel;

        public TrafficLightUserControl()
        {
            InitializeComponent();
            //_viewModel = (TrafficLightUserControlViewModel)DataContext;
            //_viewModel.StartTrafficLightChangeCycle();
        }
    }
}
