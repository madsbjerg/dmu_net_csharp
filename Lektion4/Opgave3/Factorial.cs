using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave3
{
    internal class Factorial
    { 
        public int FacRecurse(int n)
        {
            if(n > 0) return n * FacRecurse(n - 1);
            return 1;
        }
    }
}
