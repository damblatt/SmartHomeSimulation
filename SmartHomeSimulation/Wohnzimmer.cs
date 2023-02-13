﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    class Wohnzimmer : Zimmer
    {
        public Wohnzimmer(Wohnung wohnung) : base(wohnung)
        {
        }

        public Wohnzimmer(Wohnung wohnung, string name, bool personImZimmer) : base(wohnung, name, personImZimmer)
        {
        }
    }
}
