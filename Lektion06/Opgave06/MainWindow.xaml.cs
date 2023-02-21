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

namespace Opgave06
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Vest.Click += Click_Event;
            Nord.Click += Click_Event;
            Øst.Click += Click_Event;
            Syd.Click += Click_Event;
        }

        private void Click_Event(object sender, RoutedEventArgs e)
        {
            Text.Text += ((Button)sender).Name + "\n";
        }
    }
}
