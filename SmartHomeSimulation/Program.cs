namespace SmartHomeSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var wettersensor = new Wettersensor();
            var wohnung = new Wohnung(wettersensor);
            var wohnzimmer = new Wohnzimmer(wohnung, "Wohnzimmer", true);
            var zimmerMitHeizung = new ZimmerMitHeizung(wohnung, wohnzimmer);
        }
    }
}