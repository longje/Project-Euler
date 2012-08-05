using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
    class Problem53: Solution
    {
        public void Solve()
        {
            var count = 0;
            for (int i = 2; i < 101; i++)
            {
                for (int j = 2; j < 101; j++)
                {
                    BigInteger x = new BigInteger(i);
                    BigInteger y = new BigInteger(j);
                    if (combinatoricFormula(x, y) > 1000000)
                        count++;
                }
            }
            Console.WriteLine("The result is : {0}", count);
        }

        private BigInteger combinatoricFormula(BigInteger n, BigInteger r)
        {
            return ( CustomMath.factorial(n) / ( CustomMath.factorial(r) * CustomMath.factorial(n - r)));
        }
    }
}
