using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
    class Problem97: Solution
    {
        public void Solve()
        {
            Console.WriteLine((1073741824u << 1) % 10000000000);
            int maxExp = 7830457;
            ulong value = 1;
            for (int exp = 0; exp < maxExp; exp++)
            {
                value <<= 1;
                value %= 10000000000;
            }

            Console.WriteLine(value * 28433 + 1);

            /*
            var x = BigInteger.Pow(new BigInteger(2), 100000);
            var y = x * x * x * x * x * x * x * x * x * x; //1 mill
            var y3 = y * y * y; //3mill
            var z = y3 * y3 * y; // 7 mill
            var a = BigInteger.Pow(new BigInteger(2), 830457);
            
            //Console.WriteLine(z);
            Console.WriteLine(28433 * (a * z) + 1);
             */
        }
    }
}
