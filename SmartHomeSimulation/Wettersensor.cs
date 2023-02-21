namespace M320_SmartHome {
    /// <summary>
    /// Wettersensor implementiert das Interface Wettersensor.
    /// </summary>
    public class Wettersensor : IWettersensor
    {
        private Random random;
        /// <summary>
        /// saves the value of the current temperature
        /// </summary>
        private double currentTemp;
        /// <summary>
        /// sets the maximum temperature
        /// </summary>
        private const int MAX_TEMP = 35;
        /// <summary>
        /// sets the maximum temperature
        /// </summary>
        private const int MIN_TEMP = -25;
        /// <summary>
        /// standard constructor, welcher die temperatur bestimmt
        /// </summary>
        public Wettersensor() {
            this.random = new Random(Guid.NewGuid().GetHashCode());
            this.currentTemp = random.Next(MIN_TEMP, MAX_TEMP);
        }

        /// <summary>
        /// Wetterdaten werden generiert
        /// </summary>
        /// <returns>
        /// Objekt der Klasse Wetterdaten mit Aussentemperatur, Windgeschwindigkeit und Regen
        /// </returns>
        public Wetterdaten GetWetterdaten() {
            var rand = this.random.NextDouble();

            var regen = rand > 0.5;

            var deltaTemp = rand * (regen ? -1 : 1);
            var newTemp = this.currentTemp + deltaTemp;
            if(newTemp < MIN_TEMP || newTemp > MAX_TEMP) {
                deltaTemp *= -1;
            }
            this.currentTemp += deltaTemp;
            this.currentTemp = Math.Round(this.currentTemp, 1);
            var wind = Math.Round(35d * rand, 1);
           

            return new Wetterdaten { Aussentemperatur = this.currentTemp, Windgeschwindigkeit = wind, Regen = regen };
        }
    }



}
