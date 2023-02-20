using System.Runtime.CompilerServices;

namespace Opgave6
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Opgave 6
            Console.WriteLine("Hello, World!");
            List<Person> personer = Person.ReadCSVFile(@"C:\Users\terez\source\repos\DMU_NET\Lektion05\data1.csv");
            personer.SetAccepted(p => p.Age > 5);
            personer.ForEach(p => Console.WriteLine(p.ToString()));

            // Opgave 7
            List<Person> ordered = personer.OrderBy(p => p.Age).ToList<Person>();
            ordered.ForEach(p => Console.WriteLine(p.ToString()));

            ordered = ordered.OrderByDescending(p => p.Age).ToList<Person>();
            ordered.ForEach(p => Console.WriteLine(p.ToString()));

            ordered = ordered.OrderBy(p => p.Accepted).ToList<Person>();
            ordered.ForEach(p => Console.WriteLine(p.ToString()));
        }

        // Opgave 6
        public static void SetAccepted(this List<Person> lst, Predicate<Person> pred)
        {
            List<Person> result = lst.FindAll(pred);
            result.ForEach(p => p.Accepted = true);
        }
    }
}