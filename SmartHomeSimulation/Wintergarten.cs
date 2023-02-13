using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    class Wintergarten : Zimmer
    {
        public Wintergarten(Wohnung wohnung) : base(wohnung)
        {
        }

        public Wintergarten(Wohnung wohnung, string name, bool personImZimmer) : base(wohnung, name, personImZimmer)
        {
        }
    }
}
