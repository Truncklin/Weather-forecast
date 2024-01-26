using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using Newtonsoft.Json;

namespace OutdoorWeather1
{
    
    /// <summary>
    /// Логика взаимодействия для PageSetting.xaml
    /// </summary>
    public partial class PageSetting : Page
    {
        private MainWindow mainWindow;
        public string Temperature {  get; set; }
        public PageSetting()
        {
            InitializeComponent();
            Triger.Click += (sender, e) =>
            {
                try {Temperature = WeatherTemp(CityName.Text); } catch { ExeptionMessage.Text = "Не найдено"; }
                mainWindow.mapping(Temperature);
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
            return "В городе " + settingResponse.Name + " температура воздуха равна" + settingResponse.Main.Temp;
        }

    }
}
