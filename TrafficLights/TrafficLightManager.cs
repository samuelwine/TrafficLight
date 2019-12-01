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

        public TrafficLight trafficLight { get; set; }
        public RulesManager rulesManager { get; set; }
        public bool ChangeCycleEnded;
        int index = 0;

        public TrafficLightManager(TrafficLight trafficLight, RulesManager rulesManager)
        {
            this.rulesManager = rulesManager;
            this.trafficLight = trafficLight;
            trafficLight.DefaultState = rulesManager.DefaultState;
        }

        //  Changes the CUrrentState of the traffic light by setting it to the next item in States list
        public void ChangeTrafficLightState()
        {
            if (index < rulesManager.States.Count) trafficLight.CurrentState = rulesManager.States.ElementAt(index).Key;
            if (index == rulesManager.States.Count - 1) ChangeCycleEnded = true;
            index++;
        }
    }
}
