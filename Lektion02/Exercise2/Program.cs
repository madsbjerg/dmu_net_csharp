using System;

namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CalculateAge(new DateTime(1996, 12, 31), out int age);
            Console.Write("Give your age: " + age);

        }

        static void CalculateAge(DateTime inputAge, out int age)
        {
            int currentYear = DateTime.Now.Year;
            age = currentYear - inputAge.Year;

            if(DateTime.Now.Month < inputAge.Month && DateTime.Now.Day < inputAge.Day) age--;
        }
    }
}