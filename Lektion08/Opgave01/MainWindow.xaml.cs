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
using Opgave01.DAL;

namespace Opgave01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            Context context = new Context();
            InitializeComponent();
            
            // Vigtig ellers kan vi ikke connect lul
            // Code first gider ikke automatisk oprette database
            context.Database.EnsureCreated();

            foreach(BilModel bil in context.biler)
            {
                BilListe.Items.Add(bil);
            }
        }
    }
}
