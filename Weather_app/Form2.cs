using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Weather_app
{
    public partial class Forecast : Form
    {
        public Forecast()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imgIcon);
            this.Icon = Icon.FromHandle(bm.GetHicon());
        }


        public void Show_details(int number, string city_name, bool farengheit, bool celcius, Dictionary<string, string> units)
        {
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
            icon.Image = provider.GetIcons(details_data.list[number].weather[0].icon);
            temp.Text = details_data.list[number].main.temp.ToString() + " "+units["temperature"];
            condition.Text = details_data.list[number].weather[0].main + ", " + details_data.list[number].weather[0].description;
            feels_like.Text = "Feels like: "+details_data.list[number].main.feels_like.ToString() +" "+units["temperature"];
            wind.Text = "Wind: " + details_data.list[number].wind.speed.ToString()+" "+units["speed"];
            pressure.Text = "Pressure: " + details_data.list[number].main.pressure.ToString()+" "+units["pressure"];
            humidity.Text = "Humidity: " + details_data.list[number].main.humidity.ToString() + " %";
            visibility.Text = "Visibility: " + (details_data.list[number].visibility / 1000).ToString()+" "+units["visibility"];
            posibility.Text = "Chance of rain/snow: " + details_data.list[number].pop.ToString()+" %";


        }
    }
}
