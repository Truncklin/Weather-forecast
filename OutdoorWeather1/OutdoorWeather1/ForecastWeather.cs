using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OutdoorWeather1
{
    interface Weather
    {
        Weather Clone();
        string Name();
        string RespApi();
    }
    internal class ForecastWeather : Weather
    {
        public string Name()
        {
            return "";
        }
        public string RespApi() 
        {
            return ""; 
        }
        public Weather Clone()
        {
            return new ForecastWeather();
        }
        public string WeatherTemp(string city)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=" + city +
                "&units=metric&appid=24180e81b2418db8708ea2e37d2cd446";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string rezult;
            using (StreamReader streamreader = new StreamReader(response.GetResponseStream()))
            {
                rezult = streamreader.ReadToEnd();
            }
            SettingResponse settingResponse = JsonConvert.DeserializeObject<SettingResponse>(rezult);
            return "В городе " + settingResponse.Name + " температура воздуха " + settingResponse.Main.Temp;
        }
    }
}
