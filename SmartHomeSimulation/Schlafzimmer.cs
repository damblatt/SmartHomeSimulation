using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    class Schlafzimmer : Zimmer
    {
        public Schlafzimmer(Wohnung wohnung) : base(wohnung)
        {
        }

        public Schlafzimmer(Wohnung wohnung, string name, bool personImZimmer) : base(wohnung, name, personImZimmer)
        {
        }
    }
}
