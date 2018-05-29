using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WheatherCitis
{
    /// <summary>
    /// Логика взаимодействия для WeatherBlock.xaml
    /// </summary>
    public partial class WeatherBlock : UserControl
    {
        public WeatherBlock(string date,string temp,BitmapImage img)
        {
            InitializeComponent();
            dateBox.Text = date;
            iconWeather.Source = img;
            temperatureBox.Text = temp;
        }
    }
}
