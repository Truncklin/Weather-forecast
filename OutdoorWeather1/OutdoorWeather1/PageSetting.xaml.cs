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
        public string Temperature {  get; set; }
        public PageSetting( Temperature temperature)
        {
            InitializeComponent();
            Triger.Click += (sender, e) =>
            {
                ExeptionMessage.Text = "";
               // try { Temperature = WeatherTemp(CityName.Text); } catch { ExeptionMessage.Text = "Не найдено"; }

            };
        }
        
    }
}
