using System;
using System.Collections.Generic;
using System.Drawing;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_1_Left_Click(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            int R = random.Next(0,255);
            int G = random.Next(0,255);
            int B = random.Next(0,255);
            Button_1.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)R,(byte)G,(byte)B));
            MessageBox.Show(Button_1.Background.ToString());
           
        }

        private void Button_2_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);
            Button_2.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)R, (byte)G, (byte)B));
            MessageBox.Show(Button_2.Background.ToString());
        }

        private void Button_3_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);
            Button_3.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)R, (byte)G, (byte)B));
            MessageBox.Show(Button_3.Background.ToString());
        }

        private void Button_4_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);
            Button_4.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)R, (byte)G, (byte)B));
            MessageBox.Show(Button_4.Background.ToString());
        }

        private void Button_5_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);
            Button_5.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)R, (byte)G, (byte)B));
            MessageBox.Show(Button_5.Background.ToString());
        }

        private void Button_6_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Random random = new Random();
            int R = random.Next(0, 255);
            int G = random.Next(0, 255);
            int B = random.Next(0, 255);
            Button_6.Background = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)R, (byte)G, (byte)B));
            MessageBox.Show(Button_6.Background.ToString());
        }

        private void Button_1_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_1.Visibility = Visibility.Hidden;
            Title = Button_1.Content.ToString();
        }

        private void Button_2_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_2.Visibility = Visibility.Hidden;
            Title = Button_2.Content.ToString();
        }

        private void Button_3_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_3.Visibility = Visibility.Hidden;
            Title = Button_3.Content.ToString();
        }

        private void Button_4_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_4.Visibility = Visibility.Hidden;
            Title = Button_4.Content.ToString();
        }

        private void Button_5_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_5.Visibility = Visibility.Hidden;
            Title = Button_5.Content.ToString();
        }

        private void Button_6_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Button_6.Visibility = Visibility.Hidden;
            Title = Button_6.Content.ToString();
        }
    }
}
