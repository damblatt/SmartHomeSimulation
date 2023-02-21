namespace M320_SmartHome {
    internal class Program {
        static void Main(string[] args) {

            var wettersensor = new Wettersensor();
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("BadWC", 23);
            wohnung.SetTemperaturvorgabe("Küche", 22);
            wohnung.SetTemperaturvorgabe("Schlafzimmer", 19);
            wohnung.SetTemperaturvorgabe("Wohnzimmer", 22);
            wohnung.SetTemperaturvorgabe("Wintergarten", 20);

            wohnung.SetPersonenImZimmer("Küche", true);
            wohnung.SetPersonenImZimmer("Schlafzimmer", false);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);
            wohnung.SetPersonenImZimmer("Wintergarten", true);

            int zeitdauerMinuten = 30;

            for(var i = 0; i<zeitdauerMinuten; i++) {
                wohnung.GenerateWetterdaten(i+1);
            }
        }
    }
}