namespace Opgave3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial fac = new Factorial();
            Console.WriteLine(fac.FacRecurse(10));
            Console.WriteLine(fac.FacRecurse(0));

            Console.WriteLine(4.Factorial());
            Console.WriteLine(4.Power(2));

            Console.ReadKey();
        }
    }
}