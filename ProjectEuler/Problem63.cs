using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
    /*
     * The logarithm base b of a number x is the power to which b must be raised in order to equal x. This is written logb x. For example, log2 8 equals 3 since 2^3 = 8.
     * logb(m^n) = n * logb(m)
     * Digits of a number = log10(x) + 1
     * loga x = N means that a ^ N = x
     * y = a^x digits of y = log10(y) + 1 
     * digits of a^x = x * log10(a) + 1
     */
    class Problem63: Solution
    {
        public void Solve()
        {
            int count = 0;
            for (long i = 1; i < 10; i++)
                for (long j = 1; j < 30; j++)
                    if ( (int)(j * Math.Log10(i) + 1) == j )
                        count++;
            Console.WriteLine("Total : {0}", count);
        }
    }
}
