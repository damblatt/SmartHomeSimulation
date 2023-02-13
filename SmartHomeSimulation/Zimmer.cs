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


        // fuegezimmerhinzu(this) --> this funktioniert nicht richtig. wieso? zimmer kann nicht zurückgegeben werden, aber wie gebe ich die konkrete klasse zurück (z. B. wohnzimmer)
        public Zimmer(Wohnung wohnung)
        {
            wohnung.FuegeZimmerHinzu(this);
        }

        public Zimmer(Wohnung wohnung, string name, bool personImZimmer) : this(wohnung)
        {
            this.personImZimmer = personImZimmer;
            Name = name;
        }

        public virtual void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {

        }
    }
}
