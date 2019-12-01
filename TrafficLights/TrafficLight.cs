using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace TrafficLights
{
    public class TrafficLight 
    {
        //  The current state of the traffic light during the change cycle
        public int CurrentState { get; set; }

        //  The default state of the traffic light when not changing
        public int DefaultState { get; set; }       
    }
}
