using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    internal class Fibonacci
    {
        public void FibLoop(int n, out int[] seq)
        {
            seq = new int[n];
            seq[0] = 0;
            if(n != 1) seq[1] = 1;

            for (int i = 2; i < n; i++)
                seq[i] = seq[i - 1] + seq[i - 2];
        }

        public List<int> FibRecursive(int n)
        {
            List<int> res = new List<int>();
            res.Add(0);
            res.Add(1);
            if (n > 2) res.AddRange(Fib(res.ElementAt(0), res.ElementAt(1), n-2));
            return res;
        }

        public List<int> Fib(int last, int current, int n)
        {
            List<int> list = new List<int>();
            if(n != 0)
            {
                int newVal = last + current;
                list.Add(newVal);
                list.AddRange(Fib(current, newVal, n - 1));
            }
            return list;
        }

        public int[] FibRecursiveArray(int n)
        {
            int[] res = n > 2 ? new int[n] : new int[2];
            res[0] = 0;
            res[1] = 1;

            if (n > 2)
            {
                int[] temp_arr = FibArray(res[0], res[1], n - 2);
                for (int i = 0; i < temp_arr.Length; i++)
                    res[i + 2] = temp_arr[i];
            }
            return res;
        }

        public int[] FibArray(int last, int current, int n)
        {
            int[] arr = new int[n];
            if (n != 0)
            {
                int newVal = last + current;
                arr[0] = newVal;
                int[] temp_arr = FibArray(current, newVal, n - 1);
                for (int i = 0; i < temp_arr.Length; i++)
                    arr[i + 1] = temp_arr[i];
            }
            return arr;
        }
    }
}
