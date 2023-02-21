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

namespace Opgave08
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            foreach(RadioButton button in RadioStack.Children)
                button.Checked += Radio_Selected;

            foreach(CheckBox box in CheckStack.Children)
            {
                box.Checked += Check_Selected;
                box.Unchecked += Check_Unselected;
            }
        }

        private void Radio_Selected(object sender, RoutedEventArgs e)
        {
            StatusRadio.Text = ((RadioButton)sender).Name;
        }

        private void Check_Selected(object sender, RoutedEventArgs e)
        {
            StatusCheck.Text += ((CheckBox)sender).Name + "\n";
        }

        private void Check_Unselected(object sender, RoutedEventArgs e)
        {
            StatusCheck.Text = StatusCheck.Text.Replace(((CheckBox)sender).Name + "\n", "");
        }
    }
}
