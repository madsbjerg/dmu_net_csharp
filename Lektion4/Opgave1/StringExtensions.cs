using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave1
{
    public static class StringExtensions
    {
        public static bool Lang(this string str)
        {
            return str.Length > 5;
        }

        public static bool LangSpecifik(this string str, int max)
        {
            return str.Length > max;
        }
    }
}
