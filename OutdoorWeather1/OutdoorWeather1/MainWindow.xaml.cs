using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;
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
            ButtonSettings.Click += (sender, e) =>
            {
                FrameSetting.Content = new PageSetting();
            };

        }
        public void mapping(string tmp)
        {
            Temp.Text = tmp;
        }
    }
}
