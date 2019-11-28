using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class RulesManager
    {
        internal Dictionary<int, int> States { get; set; }
        internal int DefaultState { get; set; }

        public RulesManager(Dictionary<int,int> states, int defaultState)
        {
            this.States = states;
            this.DefaultState = defaultState;
        }
    }
}
