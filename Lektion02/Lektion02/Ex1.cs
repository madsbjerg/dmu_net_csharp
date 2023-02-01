namespace Exercise1
{
    internal class Ex1
    {
        static void Main(string[] args)
        {
            Fibonacci fib = new Fibonacci();
            Console.WriteLine("Welcome to Fibonacci!!!11");
            int input = int.MaxValue;
            while (input != 0)
            {
                Console.WriteLine("Write the amount of numbers you want or 0 to exit program.");
                input = int.Parse(Console.ReadLine());
                if(input != 0)
                {
                    int[] res = fib.FibLoop(input);
                    Console.WriteLine("Fibonacci sequence: ");
                    foreach (int i in res)
                        Console.Write(i + " ");
                    Console.WriteLine();
                }
            }
        }
    }
}