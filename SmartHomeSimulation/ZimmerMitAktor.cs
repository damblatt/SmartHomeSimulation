using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    abstract class ZimmerMitAktor : Zimmer
    {
        public ZimmerMitAktor(Wohnung wohnung) : base(wohnung)
        {

        }
    }
}
