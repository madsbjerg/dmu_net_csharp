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
        Person person;
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
            person = new Person("Mads", 26, 60, 120, true);
            grid.DataContext = person;

        }

        private void NewPerson_Click(object sender, RoutedEventArgs e)
        {
            char[] chars = new char[rand.Next(4, 10)];
            for (int i = 0; i < chars.Length; i++)
            {
                char c = Convert.ToChar(rand.Next(1, 255));
                chars[i] = c;
            }

            person.Name = new String(chars);
            person.Age = rand.Next(1, 100);
            person.Score = rand.Next(1, 100);
            person.Weight = rand.Next(1, 100);
            person.Accepted = rand.Next(1, 100) > 50 ? true : false;

        }

        private void PrintConsole_Click(object sender, RoutedEventArgs e)
        {
            Print.Text += person.ToString() + "\n";
        }
    }
}
