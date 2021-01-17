using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net;

namespace Provider
{
    public class Provider
    {

        private const string api_token = "3c2b1091127f22c576612e7625be30c0";



        public WeatherInfo GetCurrentWeather(string param_1,string param_2, string units_param, int search_id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");

            string response = search_id == 1 ? client.GetStringAsync("weather?q=" + param_1 + "&units=" + units_param + "&appid=" + api_token).Result : search_id == 2 ?
                client.GetStringAsync("weather?lat=" + param_1 + "&lon=" + param_2 + "&units=" + units_param + "&appid=" + api_token).Result : search_id == 3 ?
                client.GetStringAsync("weather?zip=" + param_1 + "&units=" + units_param + "&appid=" + api_token).Result : null;
            

            var result = JsonConvert.DeserializeObject<WeatherInfo>(response);

            return result;
        }

        public ForecastInfo GetForecasts(string param_1, string param_2, string units_param, int search_id)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");

            string response = search_id == 1 ? client.GetStringAsync("forecast?q=" + param_1 + "&units=" + units_param +"&cnt=40&appid=" + api_token).Result : search_id == 2 ?
                client.GetStringAsync("forecast?lat=" + param_1 + "&lon=" + param_2 + "&units=" + units_param + "&cnt=40&appid=" + api_token).Result : search_id == 3 ?
                client.GetStringAsync("forecast?zip=" + param_1 + "&units=" + units_param + "&cnt=40&appid=" + api_token).Result : null;

            var result = JsonConvert.DeserializeObject<ForecastInfo>(response);

            return result;

        }
        
        public Image GetIcons(string icon)
        {
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead("http://openweathermap.org/img/wn/" + icon + "@2x.png");

            return Image.FromStream(stream);
        }
        

        public ForecastInfo TestProvider(string test_data)
        {
            var result = JsonConvert.DeserializeObject<ForecastInfo>(test_data);

            return result;
        }


        public string AverageForecastTemp(bool fuse, string param_1, string param_2, string units_param, int search_id)
        {
            double avgTemp = 0;
            var result = fuse ? GetForecasts(param_1, param_2, units_param, search_id) : TestProvider(param_1);

            for (int i = 0; i < result.cnt; i++)
            {
                avgTemp += result.list[i].main.temp;
            }
            avgTemp = Math.Round((avgTemp / result.cnt), 2);

            return avgTemp.ToString();
        }



        public string HighestForecastTemp(bool fuse, string param_1, string param_2, string units_param, int search_id)
        {
            double highestTemp = 0;
            var result = fuse ? GetForecasts(param_1, param_2, units_param, search_id) : TestProvider(param_1);

            for (int i = 0; i < result.cnt; i++)
            {
                if (highestTemp < result.list[i].main.temp)
                {
                    highestTemp = result.list[i].main.temp;
                }
            }
            highestTemp = Math.Round(highestTemp, 2);

            return highestTemp.ToString();
        }

    }
}
