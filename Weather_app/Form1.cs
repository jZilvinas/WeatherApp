using System;
using System.Windows.Forms;
using Provider;
using System.Collections.Generic;
using System.Drawing;

namespace Weather_app
{
    
    public partial class WeatherApp : Form
    {
        string input_field= null;
        public WeatherApp()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imgIcon);
            this.Icon = Icon.FromHandle(bm.GetHicon());
            listViewForecast.View = View.Details;
            search_type.SelectedItem = "City";
        }

        public Dictionary<string, string> GetUnits()
        {
            Dictionary<string, string> units = new Dictionary<string, string>();
            if (celcius.Checked)
            {
                units.Add("temperature", "°C");
                units.Add("speed", "m/s");
                units.Add("pressure", "hPA");
                units.Add("visibility", "km");
            }
            else if (farengheit.Checked)
            {
                units.Add("temperature", "°F");
                units.Add("speed", "mph");
                units.Add("pressure", "col.");
                units.Add("visibility", "miles");
            }

            return units;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (search_field.Text == "")
            {
                search_field.PlaceholderText = "Enter value to search.";
                return;
            }

            try
             {
                search_field.PlaceholderText = null;
                var currentWeatherData = (WeatherInfo)null;
                var forecastWeatherData = (ForecastInfo)null;
                string highestForecastTemp = null;
                string averageForecastTemp = null;

                Provider.Provider provider = new Provider.Provider();
                string units = null;


                if (celcius.Checked)
                {
                    units = "metric";
                }
                else if (farengheit.Checked)
                {
                    units = "imperial";
                }

                input_field = search_field.Text;
                

                var parametersForRequest = searchParameter();
                currentWeatherData = provider.GetCurrentWeather(parametersForRequest.Item1, parametersForRequest.Item2, units, parametersForRequest.Item3);
                forecastWeatherData = provider.GetForecasts(parametersForRequest.Item1, parametersForRequest.Item2, units, parametersForRequest.Item3);

                averageForecastTemp = provider.AverageForecastTemp(true, parametersForRequest.Item1, parametersForRequest.Item2, units, parametersForRequest.Item3);
                highestForecastTemp = provider.HighestForecastTemp(true, parametersForRequest.Item1, parametersForRequest.Item2, units, parametersForRequest.Item3);

                listViewForecast.Items.Clear();
                listViewForecast.View = View.Details;
                addInfo(currentWeatherData, forecastWeatherData, averageForecastTemp, highestForecastTemp);


                search_field.Clear(); 

            }
            catch (Exception)
            {
                search_field.PlaceholderText = "Enter value to search.";
            }

        }

        public Tuple<string, string, int> searchParameter()
        {
            var generalParam = (dynamic)null;
            if (search_type.Text == "City")
            {
                string city_param = input_field;
                int searchID = 1;
                generalParam= Tuple.Create(city_param, "", searchID);
            }

            else if (search_type.Text == "Coordinates")
            {
                string[] coords = input_field.Split(" ");
                string latitude = coords[0];
                string longtitude = coords[1];
                int searchID = 2;
                generalParam = Tuple.Create(latitude, longtitude, searchID);
            }

            else if (search_type.Text == "ZIP")
            {
                string[] zip_var = input_field.Split(" ");
                string zip = zip_var[0];
                string code = zip_var[1];
                string zip_param = zip + "," + code;
                int searchID = 3;
                generalParam = Tuple.Create(zip_param, "", searchID);
            }
            return generalParam;
        }


        public void addInfo(WeatherInfo currentWeatherData, ForecastInfo forecastWeatherData, string averageForecastTemp, string highestForecastTemp)
        {
            Dictionary<string, string> units = GetUnits();
            Provider.Provider provider = new Provider.Provider();
            icon.Image = provider.GetIcons(currentWeatherData.Weather[0].icon);
            City_Name.Text = currentWeatherData.name + ", " + currentWeatherData.Sys.country;
            temperature.Text = currentWeatherData.Main.temp.ToString() + " " + units["temperature"];
            wind.Text = "Wind: " + currentWeatherData.Wind.speed + " " + units["speed"];
            condition.Text = currentWeatherData.Weather[0].main + ", " + currentWeatherData.Weather[0].description;
            feels_like.Text = "Feels like " + currentWeatherData.Main.feels_like.ToString() + " " + units["temperature"] + ".";
            pressure.Text = "Pressure: " + currentWeatherData.Main.pressure.ToString() + " " + units["speed"];
            humidity.Text = "Humidity: " + currentWeatherData.Main.humidity.ToString() + " %";
            visibility.Text = "Visibility: " + (currentWeatherData.visibility / 1000).ToString() + " " + units["visibility"];
            average_temp.Text = "Average temperature: " + averageForecastTemp + " " + units["temperature"];
            maximum_temp.Text = "Highest temerature: " + highestForecastTemp + " " + units["temperature"];


            for (var i = 0; i < forecastWeatherData.cnt; i++)
            {
                ListViewItem item = new ListViewItem();
                item.Text = (forecastWeatherData.list[i].dt_txt.DayOfWeek + " " + forecastWeatherData.list[i].dt_txt.Month + "-" + forecastWeatherData.list[i].dt_txt.Day).ToString();
                item.SubItems.Add(forecastWeatherData.list[i].dt_txt.TimeOfDay.ToString());
                item.SubItems.Add(forecastWeatherData.list[i].main.temp.ToString() + " " + units["temperature"]);
                listViewForecast.Items.Add(item);

            }
        }


        private void search_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_field.PlaceholderText = null;
            string text = search_type.Text;
            if (text == "City")
            {
                intro.Text = "Weather search by city";
                tooltip.Text = "Enter name of the city";
                search_field.Clear();
            }
            else if (text == "Coordinates")
            {
                intro.Text = "Weather search by coordinates";
                tooltip.Text = "Enter coordinates (Format: 'latitude longtitude')";
                search_field.Clear();
            }
            else if (text == "ZIP")
            {
                intro.Text = "Weather search by ZIP code";
                tooltip.Text = "Enter ZIP code (Format: 'ZIP country_code')";
                search_field.Clear();
            }
        }


        private void listViewForecast_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Forecast detailed_view_form = new Forecast();
            detailed_view_form.Show();
            detailed_view_form.Show_details(listViewForecast.SelectedIndices[0], City_Name.Text, farengheit.Checked, celcius.Checked, GetUnits());
        }



        private void farengheit_Click(object sender, EventArgs e)
        {
            try
            {
                var currentWeatherData = (WeatherInfo)null;
                var forecastWeatherData = (ForecastInfo)null;
                string highestForecastTemp = null;
                string averageForecastTemp = null;

                Provider.Provider provider = new Provider.Provider();


                var parametersForRequest = searchParameter();

                currentWeatherData = provider.GetCurrentWeather(parametersForRequest.Item1, parametersForRequest.Item2, "imperial", parametersForRequest.Item3);
                forecastWeatherData = provider.GetForecasts(parametersForRequest.Item1, parametersForRequest.Item2, "imperial", parametersForRequest.Item3);

                averageForecastTemp = provider.AverageForecastTemp(true, parametersForRequest.Item1, parametersForRequest.Item2, "imperial", parametersForRequest.Item3);
                highestForecastTemp = provider.HighestForecastTemp(true, parametersForRequest.Item1, parametersForRequest.Item2, "imperial", parametersForRequest.Item3);

                listViewForecast.Items.Clear();
                listViewForecast.View = View.Details;

                addInfo(currentWeatherData, forecastWeatherData, averageForecastTemp, highestForecastTemp);
            }

            catch(Exception)
            {
                farengheit.Checked = true;
            }
        }



        private void celcius_Click(object sender, EventArgs e)
        {
            try
            {
                var currentWeatherData = (WeatherInfo)null;
                var forecastWeatherData = (ForecastInfo)null;
                string highestForecastTemp = null;
                string averageForecastTemp = null;

                Provider.Provider provider = new Provider.Provider();


                var parametersForRequest = searchParameter();

                currentWeatherData = provider.GetCurrentWeather(parametersForRequest.Item1, parametersForRequest.Item2, "metric", parametersForRequest.Item3);
                forecastWeatherData = provider.GetForecasts(parametersForRequest.Item1, parametersForRequest.Item2, "metric", parametersForRequest.Item3);

                averageForecastTemp = provider.AverageForecastTemp(true, parametersForRequest.Item1, parametersForRequest.Item2, "metric", parametersForRequest.Item3);
                highestForecastTemp = provider.HighestForecastTemp(true, parametersForRequest.Item1, parametersForRequest.Item2, "metric", parametersForRequest.Item3);

                listViewForecast.Items.Clear();
                listViewForecast.View = View.Details;

                addInfo(currentWeatherData, forecastWeatherData, averageForecastTemp, highestForecastTemp);
            }

            catch(Exception)
            {
                celcius.Checked=true;
            }
        }
    }
}
