using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave01
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Score { get; set; }
        public bool Accepted { get; set; }

        public Person(string name, int age, int weight, int score, bool accepted)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Score = score;
            Accepted = accepted;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}, Weight: {Weight}KG, Score: {Score}, Accepted: {Accepted}";
        }
    }
}
