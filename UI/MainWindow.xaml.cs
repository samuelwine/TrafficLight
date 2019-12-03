using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;

namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<TrafficLightUserControlViewModel> trafficLights;        

        public MainWindow()
        {
            InitializeComponent();
            trafficLights = new List<TrafficLightUserControlViewModel>()
            {
                (TrafficLightUserControlViewModel)trafficLight1.DataContext,
                (TrafficLightUserControlViewModel)trafficLight2.DataContext,
            };           

            Parallel.ForEach(trafficLights, trafficLight =>
            {
                trafficLight.trafficLightManager.StartTrafficLightChangeCycle();
            });
            


        }
    }
}
