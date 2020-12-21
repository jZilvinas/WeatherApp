using System;
using System.Collections.Generic;
using System.Text;

namespace Provider
{
    public class ForecastInfo
    {
        public int cod { get; set; }
        public int message { get; set; }
        public int cnt { get; set; }
        public List<Lst_f> list { get; set; }
        public City_f city { get; set; }
    }


    public class Lst_f
    {
        public double dt { get; set; }
        public Main_f main { get; set; }
        public List<Weather_f> weather { get; set; }
        public Clouds_f clouds { get; set; }
        public Wind_f wind { get; set; }
        public float visibility { get; set; }
        public double pop { get; set; }
        public DateTime dt_txt { get; set; }

    }

    public class Main_f
    {
        public float temp { get; set; }
        public float feels_like { get; set; }
        public float temp_min { get; set; }
        public float temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }

    }

    public class Weather_f
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }

    public class Clouds_f
    {
        public int all { get; set; }
    }

    public class Wind_f
    {
        public float speed { get; set; }
        public int deg { get; set; }
    }

    public class City_f
    {
        public int id { get; set; }
        public string name { get; set; }
        public Coord_f coord { get; set; }
        public string country { get; set; }
        public double population { get; set; }
        public double timezone { get; set; }
        public double sunrise { get; set; }
        public double sunset { get; set; }
    }

    public class Coord_f
    {
        public float lat { get; set; }
        public float lon { get; set; }
    }
}
