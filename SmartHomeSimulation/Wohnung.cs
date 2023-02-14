using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace M320_SmartHome {
    public class Wohnung {
        private List<Zimmer> zimmerList = new List<Zimmer>();
        private Wettersensor wettersensor;

        public Wohnung(Wettersensor wettersensor) {
            // Wettersensor ggf. in einem ersten Schritt hier generieren. DAnn kann das später beim Testing für den WettersensorMock nach IoC umgebaut werden.
            this.wettersensor = wettersensor;

            this.zimmerList.Add(new ZimmerMitHeizungsventil(new BadWC()));
            this.zimmerList.Add(new ZimmerMitJalousiesteuerung(new ZimmerMitHeizungsventil(new Kueche())));
            this.zimmerList.Add(new ZimmerMitJalousiesteuerung(new ZimmerMitHeizungsventil(new Schlafen())));
            this.zimmerList.Add(new ZimmerMitJalousiesteuerung(new ZimmerMitMarkisensteuerung(new Wintergarten())));
            this.zimmerList.Add(new ZimmerMitJalousiesteuerung(new ZimmerMitHeizungsventil(new Wohnen())));
        }

        public void SetTemperaturvorgabe(string zimmername, double temperaturvorgabe) {
            var zimmer = this.zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if(zimmer != null) {
                zimmer.Temperaturvorgabe = temperaturvorgabe;
            }
        }

        public void SetPersonenImZimmer(string zimmername, bool personenImZimmer) {
            var zimmer = this.zimmerList.FirstOrDefault(x => x.Name == zimmername);
            if (zimmer != null) {
                zimmer.PersonenImZimmer = personenImZimmer;
            }
        }

        public void GenerateWetterdaten(int minute) {
            var wetterdaten = this.wettersensor.GetWetterdaten();

            Console.WriteLine($"\n*** Minute {minute}, Verarbeite Wetterdaten:\n    Aussentemperatur: {wetterdaten.Aussentemperatur}°C\n    Regen: {(wetterdaten.Regen ? "ja" : "nein")}\n    Windgeschwindigkeit: {wetterdaten.Windgeschwindigkeit}km/h");
            foreach(var zimmer in this.zimmerList) {
                zimmer.VerarbeiteWetterdaten(wetterdaten);
            }
        }
    }
}
