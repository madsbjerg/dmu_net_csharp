namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Kort";
            string s2 = "Lang string";
            Console.WriteLine($"Er string 1 for lang? {s1.Lang()}");
            Console.WriteLine($"Er string 2 for lang? {s2.Lang()}");
            Console.WriteLine($"Er string 1 længere end 2? {s1.LangSpecifik(2)}");
        }
    }
}