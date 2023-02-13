using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    class Wetterdaten
    {
        public bool Regen { get; set; } = true;
        public double Aussentemperatur { get; set; } = 25.0;
        public double Windgeschwindigkeit { get; set; } = 8;

        //wenn ich die methode getwetterdaten() static mache, kann ich keine wetterdaten zurückgeben --> wo generiere ich die wetterdaten (algorithmus????)
        //public Wetterdaten GetWetterDaten()
        //{
        //    return this;
        //}
    }
}
