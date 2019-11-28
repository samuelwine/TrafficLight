using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficLights
{
    class Program
    {
        static void Main(string[] args)
        {
            RulesManager rules = new RulesManager(
                new Dictionary<int, int>(){ { (int)PotentialStates.getReady, 2000}, { (int)PotentialStates.go, 2000}, },
                (int)PotentialStates.stop
                );

            TrafficLight trafficLight = new TrafficLight(rules);
            trafficLight.Change();
        }
    }
}
