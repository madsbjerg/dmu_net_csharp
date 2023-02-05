using Exercise2_6;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! \n");

            List<Medarbejder> workers = new List<Medarbejder>();

            workers.Add(new Mekaniker(new CprNr("220296", "1234"), "3", 2021, 150, "Mads Bjerg", "Ågaden 22"));
            workers.Add(new Synsfører(new CprNr("123456", "7890"), "4", 3, 2021, "Ole And", "Søen 5"));
            workers.Add(new Værkfører(new CprNr("098765", "4321"), "5", 2022, 200, 2021, 150, "Værkmand", "Værkstedet 22"));

            foreach(Medarbejder m in workers)
            {
                Console.WriteLine(m.ToString() + " \n");

            }
            Console.ReadKey();
        }
    }
}