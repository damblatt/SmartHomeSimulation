using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    class Bad : Zimmer
    {
        public Bad(Wohnung wohnung) : base(wohnung)
        {
        }

        public Bad(Wohnung wohnung, string name, bool personImZimmer) : base(wohnung, name, personImZimmer)
        {
        }
    }
}
