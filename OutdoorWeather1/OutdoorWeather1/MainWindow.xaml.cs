using System.IO;
using System.Net;
using System.Windows;
using Newtonsoft.Json;

namespace OutdoorWeather1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();


            Triger.Click += (sender, e) =>
            {
                ExeptionMessage.Text = "";
                try { Temp.Text = WeatherTemp(CityName.Text); }
                catch { ExeptionMessage.Text = "Не найдено"; }

            };
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
            return "В городе "+settingResponse.Name +" температура воздуха " +settingResponse.Main.Temp;
        }
    }
}
