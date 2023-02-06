
namespace Exercise8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Here are some workers... \n");

            List<IHarAdresse> adresser = new List<IHarAdresse>();

            adresser.Add(new Firma("Ølsmagning A/S", new Adresse("Ølleland", "42", "8200")));
            adresser.Add(new Mekaniker(new CprNr("220296", "1234"), "3", 2021, 150, "Mads Bjerg", new Adresse("Spobjergvej", "50", "8220")));
            adresser.Add(new Synsfører(new CprNr("123456", "7890"), "4", 3, 2021, "Ole And", new Adresse("Uhm", "2", "8220")));
            adresser.Add(new Værkfører(new CprNr("098765", "4321"), "5", 2022, 200, 2021, 150, "Værkmand", new Adresse("Lolvej", "200", "9000")));

            foreach(IHarAdresse m in adresser)
            {
                Console.WriteLine(m.ToString() + " \n");

            }

            Console.WriteLine("Now for collection test... \n");

            Medarbejder w1 = new Mekaniker(new CprNr("220296", "1234"), "3", 2021, 150, "Mads Bjerg", new Adresse("Spobjergvej", "50", "8220"));
            Medarbejder w2 = new Synsfører(new CprNr("123456", "7890"), "4", 3, 2021, "Ole And", new Adresse("Lottesvej", "50", "8220"));

            MedarbejderCollection customCollection = new MedarbejderCollection();
            customCollection.Add(w1.Adresse, w1);
            customCollection.Add(w2.Adresse, w2);
            var v = customCollection.Get(new Adresse("Spobjergvej", "542", "8220"));
            Console.WriteLine($"Current size: {customCollection.Size()}");

            if (v != null) Console.WriteLine(v.ToString()); else Console.WriteLine("No such key in dictionary... \n");
            v = customCollection.Get(w1.Adresse);
            if (v != null) Console.WriteLine(v.ToString());
            Console.ReadKey();
        }
    }
}