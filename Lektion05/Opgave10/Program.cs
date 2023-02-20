namespace Opgave10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];

            Random rand = new Random();
            Console.WriteLine("Initializing Array:");
            for(int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 100);
                Console.WriteLine(numbers[i].ToString());
            }


            Console.WriteLine("\nOdd numbers: ");
            // Find antallet af ulige tal I listen. 
            int[] ulige = numbers.Where(i => !(i % 2 == 0)).ToArray();
            foreach(int i in ulige) { Console.WriteLine(i.ToString()); }


            // Find antallet af unikke tal I listen (f.eks. skal 3,3,5 give 2 )  
            int unikke = numbers.Distinct().Count();
            Console.WriteLine($"\nUnique numbers: {unikke.ToString()}");

            // Find de tre første ulige tal i listen.
            int[] tre_ulige = numbers.Where(i => !(i % 2 == 0)).Take(3).ToArray();
            Console.WriteLine("\n3 første ulige tal:");
            foreach (int i in tre_ulige) Console.WriteLine(i.ToString());

            // Find alle unikke ulige tal
            Console.WriteLine("\nUnikke ulige tal");
            int[] ulige_unikke = numbers.Where(i => !(i % 2 == 0)).Distinct().ToArray();
            foreach (int i in ulige_unikke) { Console.WriteLine(i.ToString()); }


        }
    }
}