namespace Opgave1
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

            List<int> result = integerList.FindAll((i) => i % 2 == 0);      // (i) => i % 2 == 0 er vores predicate.
            result.ForEach((i) => Console.WriteLine(i));

            int temp = integerList.FindLast(i => i > 15);
            Console.WriteLine(temp);

            tmep = integerList.FindLastIndex(i => i > 15);
            Console.WriteLine(temp);
        }
    }
}