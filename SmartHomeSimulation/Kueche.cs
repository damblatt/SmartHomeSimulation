using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    class Kueche : Zimmer
    {
        public Kueche(Wohnung wohnung) : base(wohnung)
        {
        }

        public Kueche(Wohnung wohnung, string name, bool personImZimmer) : base(wohnung, name, personImZimmer)
        {
        }
    }
}
