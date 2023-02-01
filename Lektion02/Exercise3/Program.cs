using System;

namespace Exercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NormalMethod();
        }
        static void ErrorMethod(int num = 0)
        {
            throw new Exception("Error thrown");
        }

        static void NormalMethod(int num = 0)
        {
            try
            {
                ErrorMethod(10);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Doing final stuff lol");
            }
        }
    }
}