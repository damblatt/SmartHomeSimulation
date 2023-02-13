using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    internal class Wetterdaten
    {
        public bool Regen { get; set; }
        public double Aussentemperatur { get; set; }
        public double Windgeschwindigkeit { get; set; }

        public Wetterdaten GetWetterDaten()
        {
            return this;
        }
    }
}
