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

namespace Opgave01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Button button;
        private CheckBox check;
        public MainWindow()
        {
            InitializeComponent();

            Grid grid = (Grid)FindName("MainGrid");
            grid.Width = this.Width;
            grid.Height = this.Height/1.5;
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;

            button = (Button)FindName("Button");
            check = (CheckBox)FindName("CheckBox");

            check.Checked += CheckBox_Checked;
            check.Unchecked += CheckBox_Checked;

            button.Click += Button_Clicked;
        }

        // Opgave ?
        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            if(button.Visibility == Visibility.Collapsed) 
                button.Visibility = Visibility.Visible;
            else 
                button.Visibility= Visibility.Collapsed;
        }

        // Opgave 3
        private void Button_Clicked(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            char[] chars = new char[rand.Next(4,10)];
            for (int i = 0; i < chars.Length; i++)
            {
                char c = Convert.ToChar(rand.Next(1, 255));
                chars[i] = c;
            }


            button.Content = new String(chars);
        }

    }
}
