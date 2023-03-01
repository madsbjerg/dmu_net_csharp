using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave04
{
    internal class Person : INotifyPropertyChanged
    {
        private string name;
        private int age;
        private int weight;
        private int score;
        private bool accepted;
        public string Name 
        {
            get => name;
            set 
            {
                name = value;
                NotifyPropertyChanged("Name");
            } 
        }
        public int Age 
        {
            get => age; 
            set
            {
                age = value;
                NotifyPropertyChanged("Age");
            } 
        }
        public int Weight { 
            get => weight; 
            set
            {
                weight = value;
                NotifyPropertyChanged(nameof(Weight));
            }
        }
        public int Score { 
            get => score; 
            set { 
                score = value; 
                NotifyPropertyChanged(nameof(Score)); 
            } 
        }
        public bool Accepted { 
            get => accepted; 
            set { 
                accepted = value; 
                NotifyPropertyChanged(nameof(Accepted)); 
            } 
        }

        public Person(string name, int age, int weight, int score, bool accepted)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Score = score;
            Accepted = accepted;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void NotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}KG\nScore: {Score}\nAccepted: {Accepted}\n";
        }
    }
}
