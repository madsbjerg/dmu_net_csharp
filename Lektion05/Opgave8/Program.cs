namespace Opgave8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] tal = { 0, 12, 51, 2, 40, 77, 132, 91 };

            int[] ordered = tal.Select(x => x).Where(x => x.ToString().Length == 2).OrderBy(x => x).ToArray();
            for (int i = 0; i < ordered.Length; i++)
                Console.WriteLine("Int asc: " + ordered[i].ToString());

            ordered = tal.OrderByDescending(x => x).Where(x => x.ToString().Length == 2).ToArray();
            for (int i = 0; i < ordered.Length; i++)
                Console.WriteLine("Int desc: " + ordered[i].ToString());

            string[] orderedStrings = tal.Select(x => x.ToString()).OrderBy(x => x).Where(x => x.ToString().Length == 2).ToArray();
            for (int i = 0; i < orderedStrings.Length; i++)
                Console.WriteLine("String asc: " + orderedStrings[i]);

            orderedStrings = tal.Select(x => x % 2 == 0 ? x.ToString() + " even" : x.ToString() + " odd").ToArray();
            for (int i = 0; i < orderedStrings.Length; i++)
                Console.WriteLine("String odd/even: " + orderedStrings[i]);
        }
    }
}