namespace Opgave02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            List<int> integerList = new List<int>();
            integerList.Add(1);
            integerList.Add(2);
            integerList.Add(3);
            integerList.Add(4);
            integerList.Add(15);
            integerList.Add(16);
            integerList.Add(17);

            Console.WriteLine("Query methods:");
            // Query methods
            IEnumerable<int> result = integerList.Select(i => i).Where(i => i % 2 == 0);
            foreach(int i in result)
                Console.WriteLine(i);

            IEnumerable<int> result2 = integerList.Select(i => i).Where(i => i.ToString().Length == 2);

            foreach(int i in result2)
                Console.WriteLine(i);

            Console.WriteLine("Query expressions:");
            // Query expressions
            IEnumerable<int> result3 = from x in integerList where x % 2 == 0 select x;
            IEnumerable<int> result4 = from y in integerList where y.ToString().Length == 2 select y;

            foreach (int i in result3) 
                Console.WriteLine(i);

            foreach (int i in result4) 
                Console.WriteLine(i); 

        }
    }
}