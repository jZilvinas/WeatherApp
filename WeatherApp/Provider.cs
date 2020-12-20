using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Net;

namespace Weather_app
{

    public class Provider
    {

        private const string api_token = "3c2b1091127f22c576612e7625be30c0";



        public WeatherInfo GetCurrentWeather(string c_parameter)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");
            string response = client.GetStringAsync("weather?" + c_parameter + "&appid=" + api_token).Result;

            var result = JsonConvert.DeserializeObject<WeatherInfo>(response);

            return result;
        }

        public ForecastInfo GetForecasts(string f_parameter)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://api.openweathermap.org/data/2.5/");
            string response = client.GetStringAsync("forecast?" + f_parameter + "&cnt=40&appid=" + api_token).Result;

            var result = JsonConvert.DeserializeObject<ForecastInfo>(response);

            return result;

        }

        public Image GetIcons(string icon)
        {
            WebClient webClient = new WebClient();
            Stream stream = webClient.OpenRead("http://openweathermap.org/img/wn/"+icon+"@2x.png");

            return Image.FromStream(stream);
        }


        public ForecastInfo TestProvider(string test_data)
        {
            var result = JsonConvert.DeserializeObject<ForecastInfo>(test_data);

            return result;
        }


        public string AverageForecastTemp(bool fuse , string param)
        {
            double avgTemp = 0;
            if (fuse== true)
            {
                var result = GetForecasts(param);

                for (int i = 0; i < result.cnt ; i++)
                {
                    avgTemp += result.list[i].main.temp;
                }
                avgTemp = Math.Round((avgTemp / result.cnt), 2);
            }

            else if (fuse==false)
                {
                var result = TestProvider(param);

                for (int i = 0; i < result.cnt; i++)
                {
                    avgTemp += result.list[i].main.temp;
                }
                avgTemp = Math.Round((avgTemp / result.cnt), 2);
            }

            return avgTemp.ToString();
        }



        public string HighestForecastTemp(bool fuse, string param)
        {
            double highestTemp = 0;
            if (fuse==true)
            {
                var result = GetForecasts(param);
                for (int i = 0; i < result.cnt; i++)
                {
                    if (highestTemp < result.list[i].main.temp)
                    {
                        highestTemp = result.list[i].main.temp;
                    }
                }
                highestTemp = Math.Round(highestTemp, 2);
            }

            else if (fuse== false)
            {
                var result = TestProvider(param);

                for (int i = 0; i < result.cnt; i++)
                {
                    if (highestTemp < result.list[i].main.temp)
                    {
                        highestTemp = result.list[i].main.temp;
                    }
                }
                highestTemp = Math.Round(highestTemp, 2);
            }    

            return highestTemp.ToString();
        }

    }
}
