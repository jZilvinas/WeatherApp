using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Weather_app
{
    public partial class Forecast : Form
    {
        public Forecast()
        {
            InitializeComponent();
        }


        public void Show_details(int number, string city_name, bool farengheit, bool celcius, string[] units_arr)
        {
            WeatherApp weatherApp = new WeatherApp();
            Provider.Provider provider = new Provider.Provider();

            string unit_param = null;
            if (celcius ==true)
            {
                unit_param = "metric";
            }
            else if (farengheit == true)
            {
                unit_param = "imperial";
            }    

            var details_data = provider.GetForecasts(city_name, null,unit_param,1);
            date.Text = (details_data.list[number].dt_txt.DayOfWeek + " " + details_data.list[number].dt_txt.Month + "-" + details_data.list[number].dt_txt.Day+" "+details_data.list[number].dt_txt.TimeOfDay).ToString();
            //icon.Image = provider.GetIcons(details_data.list[number].weather[0].icon);
            temp.Text = details_data.list[number].main.temp.ToString() + " "+units_arr[0];
            condition.Text = details_data.list[number].weather[0].main + ", " + details_data.list[number].weather[0].description;
            feels_like.Text = "Feels like: "+details_data.list[number].main.feels_like.ToString() +" "+units_arr[0];
            wind.Text = "Wind: " + details_data.list[number].wind.speed.ToString()+" "+units_arr[1];
            pressure.Text = "Pressure: " + details_data.list[number].main.pressure.ToString()+" "+units_arr[2];
            humidity.Text = "Humidity: " + details_data.list[number].main.humidity.ToString() + " %";
            visibility.Text = "Visibility: " + (details_data.list[number].visibility / 1000).ToString()+" "+units_arr[3];
            posibility.Text = "Chance of rain/snow: " + details_data.list[number].pop.ToString()+" %";


        }
    }
}
