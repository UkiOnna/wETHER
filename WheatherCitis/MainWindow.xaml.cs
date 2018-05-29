using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.IO;

namespace WheatherCitis
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void GetWheather(object sender, RoutedEventArgs e)
        {
            stackPan.Children.Clear();
            var obj = await DownloadXml(cityBox.Text);
            if (obj == null)
            {
                MessageBox.Show("Нет такого города");
            }

            else
            {

                foreach (var s in obj.Forecast.Forecastday)
                {

                    var ms = await DownloadImage(s);
                    var bi = new BitmapImage();
                    bi.BeginInit();
                    bi.StreamSource = ms;
                    bi.EndInit();
                    // img.Source = bi;
                    stackPan.Children.Add(new WeatherBlock(s.Date.ToString(), "+" + s.Day.AvgtempC, bi));
                }
            }
            // ShowImage(bi);
            // textBlockDisc.Text = obj.explanation;
        }

        private Task<Root> DownloadXml(string city)
        {


            return Task.Run(() =>
            {
                string valueXml;
                Root newRoot;

                    //data = DateTime.ParseExact(data.Value.Date.ToString(), "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    try
                {
                    using (var webClient = new WebClient())
                    {
                        webClient.Encoding = Encoding.UTF8;
                        valueXml = webClient.DownloadString("http://api.apixu.com/v1/forecast.xml?key=02d3de968c424e20b5a74149172409%20&q=" + city + "&" + "days=7");
                        XmlSerializer formatter = new XmlSerializer(typeof(Root));
                        using (TextReader fs = new StringReader(valueXml))
                        {
                            newRoot = (Root)formatter.Deserialize(fs);
                            return newRoot;
                        }
                    }
                }
                catch
                {
                    return null;
                }

            });


        }
        private Task<MemoryStream> DownloadImage(Forecastday obj)
        {
            return Task.Run(() =>
            {
                // var c = new WebClient();
                using (var c = new WebClient())
                {
                    obj.Day.Condition.Icon = "https:" + obj.Day.Condition.Icon;
                    var bytes = c.DownloadData(obj.Day.Condition.Icon);
                    var ms = new MemoryStream(bytes);
                    return ms;
                }
            });
        }
    }
}
    

