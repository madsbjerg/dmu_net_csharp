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

namespace Opgave02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Top.Click += Switch_Top;
            Bottom.Click += Switch_Bottom;

        }

        // Opgave 5 (Kunne også bruge Grid.Children og lave en metode)
        private void Switch_Top(object sender, RoutedEventArgs e)
        {
            string temp = TopRight.Text;
            TopRight.Text = TopLeft.Text;
            TopLeft.Text = temp;
        }

        private void Switch_Bottom(object sender, RoutedEventArgs e)
        {
            string temp = BottomRight.Text;
            BottomRight.Text = BottomLeft.Text;
            BottomLeft.Text = temp;
        }
    }
}
