using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
    class Problem56: Solution
    {
        public void Solve()
        {
            int biggestDigSum = 0;
            for (int i = 2; i < 100; i++)
                for (int j = 2; j < 100; j++)
                    if (digitalSum(BigInteger.Pow(new BigInteger(i), j)) > biggestDigSum)
                        biggestDigSum = digitalSum(BigInteger.Pow(new BigInteger(i), j));
            Console.WriteLine("Biggest sum is: {0}", biggestDigSum);
        }

        private int digitalSum(BigInteger x)
        {
            var temp = x.ToString();
            int count = 0;
            foreach (var y in temp)
                count += Int32.Parse(y.ToString());
            return count;
        }
    }
}
