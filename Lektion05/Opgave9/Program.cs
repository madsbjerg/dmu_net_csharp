using System;

namespace Opgave9
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        public static void SetAccepted(this List<Person> lst, Predicate<Person> pred)
        {
            List<Person> result = lst.FindAll(pred);
            result.ForEach(p => p.Accepted = true);
        }

        public static void Reset(this List<Person> lst)
        {
            lst.ForEach(p => p.Accepted = false);
        }
    }
}