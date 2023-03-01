using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Opgave04
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Person> personer;
        Random rand = new Random();
        public MainWindow()
        {
            InitializeComponent();
            personer = new ObservableCollection<Person>();
            personer.Add(new Person("Mads", 26, 60, 140, true));
            personBox.ItemsSource = personer;
            grid.DataContext = personer;
            PrintConsole.Click += PrintConsole_Click;
        }


        private void NewPerson_Click(object sender, RoutedEventArgs e)
        {
            char[] chars = new char[rand.Next(4, 10)];
            for (int i = 0; i < chars.Length; i++)
            {
                char c = Convert.ToChar(rand.Next(1, 255));
                chars[i] = c;
            }

            Person p = new Person(
                new String(chars), 
                rand.Next(1, 100), 
                rand.Next(1, 100), 
                rand.Next(1, 100),
                rand.Next(1, 100) > 50 ?
                true : false
            );
            personer.Add(p);
        }

        private void PrintConsole_Click(object sender, RoutedEventArgs e)
        {
            int index = personBox.SelectedIndex;
            System.Diagnostics.Trace.WriteLine(personer[index].ToString());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditWindow wind = new EditWindow();
            wind.Show();
        }
    }
}
