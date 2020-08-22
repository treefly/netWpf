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
using WpfApp8.DesignPattern;

namespace WpfApp8
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnAddLog_Click(object sender, RoutedEventArgs e)
        {
            Run run = new Run();
            run.Text = DateTime.Now.ToLongDateString() +"\n";
            run.Foreground = Brushes.Red ;
            //txtShowError.Inlines.Add(run);
        }

        private void btnAdd1_Click(object sender, RoutedEventArgs e)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
            weatherData.SetMeasurements(10, 20, 30);
        }
    }
}
