namespace Opgave6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            List<Person> personer = new List<Person>();
            personer.Add(new Person(12, "Lotte", 300));
            personer.Add(new Person(15, "Jens", 100));
            personer.Add(new Person(14, "Johannes", 200));
            personer.Add(new Person(42, "Alin", 50));

            Console.WriteLine("\nSorteret efter alder: ");
            //personer.Sort(new Person.ByAgeSorter());
            personer.Sort(delegate (Person x, Person y)
            {
                return x.Age.CompareTo(y.Age);
            });
            foreach (Person p in personer)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("\nSorteret efter navn: ");
            //personer.Sort(new Person.ByNameSorter());
            personer.Sort(delegate (Person x, Person y)
            {
                return x.Name.CompareTo(y.Name);
            });
            foreach (Person p in personer)
            {
                Console.WriteLine(p.ToString());
            }

            Console.WriteLine("\nSorteret efter weight: ");
            //personer.Sort(new Person.ByWeightSorter());
            personer.Sort(delegate (Person x, Person y)
            {
                return x.Weight.CompareTo(y.Weight);
            });
            foreach (Person p in personer)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}