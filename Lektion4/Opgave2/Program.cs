namespace Opgave2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            PowerPlant pp = new PowerPlant();

            pp.SetWarning(WarningToConsole);
            pp.AddWarning(WarningToLol);

            for(int i = 0; i < 10; i++)
                pp.HeatUp();

            Console.ReadKey();
        }

        static void WarningToConsole()
        {
            Console.WriteLine("LMAO");
        }
        static void WarningToLol()
        {
            Console.WriteLine("LOL");
        }
    }
}