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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            labelRight.Foreground = Brushes.Gray;
            labelRight.Text = "123123213123";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Storyboard data = (TryFindResource("storyboardRight2") as Storyboard);
            Storyboard.SetTargetName(data.Children[0], "labelRight");
            data.Begin();
        }

        private void labelRight_TextChanged(object sender, TextChangedEventArgs e)
        {
            var storyboard = new Storyboard();


            ;
            Storyboard.SetTarget(storyboard, labelRight as TextBox);

            Storyboard.SetTargetProperty(storyboard, new PropertyPath("(Control.Foreground).(SolidColorBrush.Color)"));

            var colorAnm = new ColorAnimation(Colors.Red, new Duration(TimeSpan.FromSeconds(0.5)));

            colorAnm.From = Colors.Green;

            storyboard.Children.Add(colorAnm);

            storyboard.Begin();
        }
    }
}
