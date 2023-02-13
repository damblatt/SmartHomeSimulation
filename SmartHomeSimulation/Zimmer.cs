using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    abstract class Zimmer
    {
        protected double temperaturvorgabe;
        protected bool personImZimmer;
        public string Name { get; }

        public Zimmer(string name)
        {
            this.Name = name;
        }

        public virtual void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {

        }
    }
}
