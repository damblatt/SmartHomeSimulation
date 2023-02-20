using M320_SmartHome;

namespace SmartHomeSimulation.Test
{
    [TestClass]
    public class TestHeizungsventil
    {
        [TestMethod]
        public void TestMit15Grad_false()
        {
            // Arrange
            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(15, 19.8, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            // Act
            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            // Assert
            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, true);
        }

        [TestMethod]
        public void TestMit25Grad_false()
        {
            // Arrange
            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(25, 19.8, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            // Act
            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            // Assert
            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, false);
        }

        [TestMethod]
        public void TestMitMinus50Grad_true()
        {
            // Arrange
            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(-50, 19.8, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            // Act
            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            // Assert
            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, true);
        }

        [TestMethod]
        public void TestMit100Grad_false()
        {
            // Arrange
            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(100, 19.8, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 20);
            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            wohnung.GenerateWetterdaten(zeitdauerMinuten);

            // Act
            var wohnzimmer = wohnung.GetZimmer<ZimmerMitHeizungsventil>("Wohnzimmer");

            // Assert
            Assert.AreEqual(wohnzimmer.HeizungsventilOffen, false);
        }
    }
}