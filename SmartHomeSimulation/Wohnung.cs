using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHomeSimulation
{
    class Wohnung
    {
        public List<Zimmer> ZimmerListe { get; set; }
        public Wettersensor Wettersensor { get; set; }

        public Wohnung(Wettersensor wettersensor)
        {
            if (Wettersensor != null) {
                Console.WriteLine("Bereits ein Wettersensor vorhanden");
            }
            else {
                Wettersensor = wettersensor;
            }
        }

        // aggregation
        public void FuegeZimmerHinzu(Zimmer zimmer)
        {
            ZimmerListe.Add(zimmer);
        }
    }
}
