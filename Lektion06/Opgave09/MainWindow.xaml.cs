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

namespace Opgave09
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AddLeft.Click += Add;
            AddRight.Click += Add;

            MoveToRight.Click += Move;
            MoveToLeft.Click += Move;

            ClearLeft.Click += Clear;
            ClearRight.Click += Clear;
        }

        private void Add(object sender,RoutedEventArgs e)
        { 
            Button btn = (Button)sender;
            TextBox input;
            ListBox box;

            if (btn.Name.Contains("Right"))
            {
                input = InputRight;
                box = ListRight;
            }
            else
            {
                input = InputLeft;
                box = ListLeft;
            }

            if (input.Text.Length > 0) box.Items.Add(input.Text);

            input.Text = "";
        }

        private void Move(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            ListBox senderBox, receiverBox;

            if (btn.Name.Contains("Right"))
            {
                senderBox = ListLeft;
                receiverBox = ListRight;
            }
            else
            {
                senderBox = ListRight;
                receiverBox = ListLeft;
            }

            if (senderBox.SelectedItem == null) return;

            List<string> movedItems = new List<string>();
            foreach(string item in senderBox.SelectedItems) 
            {
                receiverBox.Items.Add(item);
                movedItems.Add(item);
            }

            foreach(string item in movedItems)
                senderBox.Items.Remove(item);
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            ListBox box;
            box = ((Button)sender).Name.Contains("Left") ? ListLeft : ListRight;
            box.Items.Clear();
        }
    }
}
