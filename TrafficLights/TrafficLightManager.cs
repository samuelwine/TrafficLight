using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace TrafficLights
{
    public class TrafficLightManager
    {

        public TrafficLight TrafficLight { get; set; }
        public RulesManager RulesManager { get; set; }
        private Timer stateChangeTimer { get; set; }
        public bool ChangeCycleEnded;
        int index = 0;

        public TrafficLightManager(TrafficLight trafficLight, RulesManager rulesManager)
        {
            this.RulesManager = rulesManager;
            this.TrafficLight = trafficLight;
            TrafficLight.DefaultState = rulesManager.DefaultState;         
        }

        //  Changes the CUrrentState of the traffic light by setting it to the next item in States list
        public void ChangeTrafficLightState()
        {
            if (ChangeCycleEnded)
            {
                stateChangeTimer.Stop();
                TrafficLight.CurrentState = TrafficLight.DefaultState;
                return;
            }
            if (index < RulesManager.States.Count) TrafficLight.CurrentState = RulesManager.States.ElementAt(index).Key;
            if (index == RulesManager.States.Count - 1) ChangeCycleEnded = true;
            index++;
        }

        public void StartTrafficLightChangeCycle()
        {
            stateChangeTimer = new Timer(2000);
            stateChangeTimer.AutoReset = true;
            stateChangeTimer.Elapsed += StateChangeTimer_Elapsed;
            stateChangeTimer.Start();
        }

        private void StateChangeTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ChangeTrafficLightState();
        }
    }
}
