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

namespace Opgave07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Open.Click += MenuItem_Clicked;
            Save.Click += MenuItem_Clicked;
            New.Click += MenuItem_Clicked;
        }

        private void MenuItem_Clicked(object sender, RoutedEventArgs e)
        {
            LastClicked.Content = ((MenuItem)sender).Name;
        }
    }
}
