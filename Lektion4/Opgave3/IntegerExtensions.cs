using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    public static class IntegerExtensions
    {
        public static int Factorial(this int value)
        {
            Factorial fac = new Factorial();
            return fac.FacRecurse(value);
        }

        public static int Power(this int value, int power)
        {
            int startVal = value;
            for (int i = 0; i < power; i++)
                value *= startVal;

            return value;
        }
    }
}
