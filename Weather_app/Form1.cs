using System;
using System.Windows.Forms;
using Provider;

namespace Weather_app
{
    
    public partial class WeatherApp : Form
    {
        public WeatherApp()
        {
            InitializeComponent();
            listViewForecast.View = View.Details;
            search_type.SelectedItem = "City";
        }


        public string[] GetUnits()
        {
            string unit = null;
            if (celcius.Checked)
            {
                unit = "°C, m/s, hPA, km" ;
            }
            else if (farengheit.Checked)
            {
                unit = "°F, ml/h, col., miles";
            }
            string[] units = unit.Split(", ");
            return units;
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string[] units_arr = GetUnits();

            try
             {
                listViewForecast.Items.Clear();
                listViewForecast.View = View.Details;
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


                if (search_type.Text == "City")
                {
                    //string city_param = "q="+search_field.Text+"&units="+units;
                    string city_param = search_field.Text;
                    currentWeatherData = provider.GetCurrentWeather(city_param, null, units, 1) ;
                    forecastWeatherData = provider.GetForecasts(city_param, null, units, 1) ;

                     averageForecastTemp = provider.AverageForecastTemp(true, city_param, null, units, 1);
                     highestForecastTemp = provider.HighestForecastTemp(true, city_param, null, units, 1);


                }
                else if (search_type.Text == "Coordinates")
                {
                    string[] coords = search_field.Text.Split(" ");
                    string latitude = coords[0];
                    string longtitude = coords[1];

                    currentWeatherData = provider.GetCurrentWeather(latitude, longtitude, units, 2);
                    forecastWeatherData = provider.GetForecasts(latitude, longtitude, units, 2);

                    averageForecastTemp = provider.AverageForecastTemp(true, latitude, longtitude, units, 2);
                    highestForecastTemp = provider.HighestForecastTemp(true, latitude, longtitude, units, 2);
                }
                else if (search_type.Text == "ZIP")
                {
                    string[] zip_var = search_field.Text.Split(" ");
                    string zip = zip_var[0];
                    string code = zip_var[1];
                    string zip_param = zip+","+code;

                    currentWeatherData = provider.GetCurrentWeather(zip_param, null, units, 3);
                    forecastWeatherData = provider.GetForecasts(zip_param, null, units, 3);

                    highestForecastTemp = provider.HighestForecastTemp(true, zip_param, null, units, 3);
                    averageForecastTemp = provider.AverageForecastTemp(true, zip_param, null, units, 3);
                }


                //icon.Image = provider.GetIcons(currentWeatherData.Weather[0].icon);
                City_Name.Text = currentWeatherData.name +", " + currentWeatherData.Sys.country;
                temperature.Text = currentWeatherData.Main.temp.ToString() + " "+units_arr[0];
                wind.Text = "Wind: "+currentWeatherData.Wind.speed + " "+units_arr[1];
                condition.Text = currentWeatherData.Weather[0].main + ", " + currentWeatherData.Weather[0].description;    
                feels_like.Text = "Feels like " + currentWeatherData.Main.feels_like.ToString() + " "+units_arr[0]+".";
                pressure.Text = "Pressure: "+currentWeatherData.Main.pressure.ToString()+" "+units_arr[2];
                humidity.Text = "Humidity: "+currentWeatherData.Main.humidity.ToString()+" %";
                visibility.Text = "Visibility: " + (currentWeatherData.visibility / 1000).ToString()+" "+units_arr[3];
                average_temp.Text = "Average temperature: " + averageForecastTemp + " " + units_arr[0];
                maximum_temp.Text = "Highest temerature: " + highestForecastTemp + " " + units_arr[0];

                

                
                for (var i=0; i<forecastWeatherData.cnt;i++)
                    {
                        ListViewItem item = new ListViewItem();
                        item.Text = (forecastWeatherData.list[i].dt_txt.DayOfWeek+" "+ forecastWeatherData.list[i].dt_txt.Month+"-"+ forecastWeatherData.list[i].dt_txt.Day).ToString();
                        item.SubItems.Add(forecastWeatherData.list[i].dt_txt.TimeOfDay.ToString());
                        item.SubItems.Add(forecastWeatherData.list[i].main.temp.ToString()+ " "+units_arr[0]);
                        listViewForecast.Items.Add(item);

                    }

                search_field.Clear(); 

            }
            catch (Exception)
            {
                search_field.Text = "Enter value to search.";
            }

        }


        private void search_type_SelectedIndexChanged(object sender, EventArgs e)
        {
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

       
    }
}
