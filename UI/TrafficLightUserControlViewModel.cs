using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;
using System.Windows.Threading;
using TrafficLights;

namespace UI
{
    class TrafficLightUserControlViewModel : INotifyPropertyChanged
    {
        public TrafficLight trafficLight { get; set; }
        public TrafficLightManager trafficLightManager { get; set; }

        //  Color property for top light
        private Brush top;
        public Brush Top
        {
            get { return top; }
            set
            {
                top = value;
                NotifyPropertyChanged();
            }
        }

        //  Color property for middle light
        private Brush middle;
        public Brush Middle
        {
            get { return middle; }
            set
            {
                middle = value;
                NotifyPropertyChanged();
            }
        }

        //  Color property for lower light
        private Brush lower;
        public Brush Lower
        {
            get { return lower; }
            set
            {
                lower = value;
                NotifyPropertyChanged();
            }
        }


        public TrafficLightUserControlViewModel()
        {
            RulesManager rules = new RulesManager
            {
                States = new Dictionary<int, int>() { { (int)PotentialStates.getReady, 2000 }, { (int)PotentialStates.go, 5000 }, { (int)PotentialStates.revertingToDefault, 2000 } },
                DefaultState = (int)PotentialStates.stop
            };

            this.trafficLight = new TrafficLight();
            this.trafficLightManager = new TrafficLightManager(trafficLight, rules);
            trafficLight.PropertyChanged += (s,e) => SetColors();
        }

        //  Sets the colors of the lights based on the current state
        public void SetColors()
        {
            switch (trafficLight.CurrentState)
            {
                case (int)PotentialStates.getReady:
                    Top = Brushes.Red;
                    Middle = Brushes.Orange;
                    Lower = Brushes.Transparent;
                    break;

                case (int)PotentialStates.go:
                    Top = Brushes.Transparent;
                    Middle = Brushes.Transparent;
                    Lower = Brushes.Green;
                    break;

                case (int)PotentialStates.revertingToDefault:
                    Top = Brushes.Transparent;
                    Middle = Brushes.Orange;
                    Lower = Brushes.Transparent;
                    break;

                case (int)PotentialStates.stop:
                    Top = Brushes.Red;
                    Middle = Brushes.Transparent;
                    Lower = Brushes.Transparent;
                    break;
            }
        }        

        //  Event and EventHandler for updating bound properties
        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }





    }
}
