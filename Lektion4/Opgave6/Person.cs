using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Opgave6
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public Person(int age, string name, int weight)
        {
            Age = age;
            Name = name;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {Age}\nWeight: {Weight}kg";
        }

        public class ByAgeSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            }
        }

        public class ByNameSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Name.CompareTo(y.Name);
            }
        }

        public class ByWeightSorter : IComparer<Person>
        {
            public int Compare(Person x, Person y)
            {
                return x.Weight.CompareTo(y.Weight);
            }
        }
    }
}
