using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    public class RulesManager
    {
        public Dictionary<int, int> States { get; set; }
        public int DefaultState { get; set; }       
    }
}
