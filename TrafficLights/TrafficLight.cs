using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace TrafficLights
{
    class TrafficLight
    {
        private int CurrentState { get; set; }
        private int DefaultState { get; set; }
        private RulesManager Rules { get; set; }

        public TrafficLight(RulesManager rules)
        {
            this.Rules = rules;
            DefaultState = rules.DefaultState;
        }

        internal void Change() 
        {
            foreach (var state in Rules.States)
            {
                CurrentState = state.Key;
                Console.WriteLine(CurrentState);
                Thread.Sleep(state.Value);
            }

            CurrentState = DefaultState;
            Console.WriteLine(CurrentState);
            Console.ReadLine();
        }        
    }
}
