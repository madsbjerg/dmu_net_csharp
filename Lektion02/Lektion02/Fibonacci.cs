using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Fibonacci
    {
        public int X { get; private set; }
        public int Y { private get; set; }


        public int[] FibLoop(int n)
        {
            int[] seq = new int[n];
            seq[0] = 0;
            if(n != 1) seq[1] = 1;

            for (int i = 2; i < n; i++)
                seq[i] = seq[i - 1] + seq[i - 2];

            return seq;
        }

        public int[] FibRecursive(int n)
        {
            int[] res = new int[n];
            return res;
        }

        public int Fib(int last, int current, int n)
        {

        }
    }
}
