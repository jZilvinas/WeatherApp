using NUnit.Framework;

namespace NUnitTestProject1
{
    public class Tests
    {
        Provider.Provider provider = new Provider.Provider();
        string test_data = "{\"cod\":\"200\",\"message\":0,\"cnt\":5," +
            "\"list\":[" +
            "{\"dt\":1608498000," +
            "\"main\":" +
            "{\"temp\":1.2,\"feels_like\":-3.99,\"temp_min\":0.36,\"temp_max\":1.2,\"pressure\":1028,\"sea_level\":1028,\"grnd_level\":1021,\"humidity\":96,\"temp_kf\":0.84},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03n\"}],\"clouds\":{\"all\":49},\"wind\":{\"speed\":4.72,\"deg\":176},\"visibility\":10000,\"pop\":0,\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2020-12-20 21:00:00\"},{\"dt\":1608508800,\"main\":{\"temp\":0.72,\"feels_like\":-4.46,\"temp_min\":0.37,\"temp_max\":0.72,\"pressure\":1028,\"sea_level\":1028,\"grnd_level\":1021,\"humidity\":95,\"temp_kf\":0.35},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03n\"}],\"clouds\":{\"all\":45},\"wind\":{\"speed\":4.57,\"deg\":178},\"visibility\":10000,\"pop\":0,\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2020-12-21 00:00:00\"},{\"dt\":1608519600,\"main\":{\"temp\":0.53,\"feels_like\":-5.21,\"temp_min\":0.43,\"temp_max\":0.53,\"pressure\":1027,\"sea_level\":1027,\"grnd_level\":1020,\"humidity\":95,\"temp_kf\":0.1},\"weather\":[{\"id\":803,\"main\":\"Clouds\",\"description\":\"broken clouds\",\"icon\":\"04n\"}],\"clouds\":{\"all\":59},\"wind\":{\"speed\":5.32,\"deg\":179},\"visibility\":10000,\"pop\":0,\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2020-12-21 03:00:00\"},{\"dt\":1608530400,\"main\":{\"temp\":0.24,\"feels_like\":-5.54,\"temp_min\":0.23,\"temp_max\":0.24,\"pressure\":1027,\"sea_level\":1027,\"grnd_level\":1020,\"humidity\":96,\"temp_kf\":0.01},\"weather\":[{\"id\":802,\"main\":\"Clouds\",\"description\":\"scattered clouds\",\"icon\":\"03n\"}],\"clouds\":{\"all\":49},\"wind\":{\"speed\":5.36,\"deg\":177},\"visibility\":10000,\"pop\":0,\"sys\":{\"pod\":\"n\"},\"dt_txt\":\"2020-12-21 06:00:00\"},{\"dt\":1608541200,\"main\":{\"temp\":1.01,\"feels_like\":-5.65,\"temp_min\":1.01,\"temp_max\":1.01,\"pressure\":1027,\"sea_level\":1027,\"grnd_level\":1020,\"humidity\":90,\"temp_kf\":0},\"weather\":[{\"id\":801,\"main\":\"Clouds\",\"description\":\"few clouds\",\"icon\":\"02d\"}],\"clouds\":{\"all\":24},\"wind\":{\"speed\":6.58,\"deg\":179},\"visibility\":10000,\"pop\":0,\"sys\":{\"pod\":\"d\"},\"dt_txt\":\"2020-12-21 09:00:00\"}],\"city\":{\"id\":598316,\"name\":\"Kaunas\",\"coord\":{\"lat\":54.9,\"lon\":23.9},\"country\":\"LT\",\"population\":374643,\"timezone\":7200,\"sunrise\":1608446792,\"sunset\":1608472662}}";

   [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void Test_average_forecast_temperature()
        {
            Provider.Provider provider = new Provider.Provider();
            var avg = decimal.Parse(provider.AverageForecastTemp(false, test_data, null, null, 0)) ;
            Assert.AreEqual(0.74, avg);
        }

        [Test]
        public void Test_max_forecast_temperature()
        {
            Provider.Provider provider = new Provider.Provider();
            var max = decimal.Parse(provider.HighestForecastTemp(false, test_data, null, null, 0));
            Assert.AreEqual(1.2, max);
        }

        [Test]
        public void Test_if_data_parsed_correctly()
        {
            Provider.Provider provider = new Provider.Provider();
            var result = provider.TestProvider(test_data);
            Assert.AreEqual("Kaunas", result.city.name);
            Assert.AreEqual("LT", result.city.country);
            Assert.AreEqual("54,9", result.city.coord.lat.ToString());
            Assert.AreEqual("23,9", result.city.coord.lon.ToString());
        }

    }
}