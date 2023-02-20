namespace Opgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /** OPGAVE 3 **/
            Console.WriteLine("Opgave3");
            Console.WriteLine("Hello, World!");
            List<Person> people = Person.ReadCSVFile(@"C:\Users\terez\source\repos\DMU_NET\Lektion05\data1.csv");

            Console.WriteLine("Score under 2:");
            List<Person> result = people.FindAll(p => p.Score < 2);
            result.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("\nScore is even:");
            result = people.FindAll(p => p.Score % 2 == 0);
            result.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("\nScore is even and weight greater than 60:");
            result = people.FindAll(p => p.Score % 2 == 0 && p.Weight > 60);
            result.ForEach(p => Console.WriteLine(p.ToString()));

            Console.WriteLine("\nEvery weight divisible by 3:");
            result = people.FindAll(p => p.Weight % 3 == 0);
            result.ForEach(p => Console.WriteLine(p.ToString()));


            /** OPGAVE 4 **/
            Console.WriteLine("\nOpgave4");

            int index = people.FindIndex(p => p.Score == 3);
            Console.WriteLine(index);

            index = people.FindIndex(p => p.Score == 3 && p.Age < 10);
            Console.WriteLine(index);

            result = people.FindAll(p => p.Score == 3 && p.Age < 10);
            result.ForEach(p => Console.WriteLine(p.ToString()));

            index = people.FindIndex(p => p.Age < 8 && p.Score == 3);
            Console.WriteLine(index); // -1, altså ^ findes ikke.
        }
    }
}