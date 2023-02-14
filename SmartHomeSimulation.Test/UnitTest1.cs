using M320_SmartHome;

namespace SmartHomeSimulation.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int zeitdauerMinuten = 30;

            var wettersensor = new WettersensorMock(16.4, 19.8, true);
            var wohnung = new Wohnung(wettersensor);

            wohnung.SetTemperaturvorgabe("Wohnzimmer", 22);

            wohnung.SetPersonenImZimmer("Wohnzimmer", true);

            // Act
            ZimmerMitAktor zimmer = wohnung.zimmerList.FirstOrDefault(x => x.Name == "Wohnzimmer");

            // Assert
            Assert.AreEqual(zimmer., true);
        }
    }
}