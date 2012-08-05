using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem51: Solution
    {
        public void Solve()
        {
            List<int> primes = new List<int>();
            for (int i = 2; i < 100; i += 2)
                if (CustomMath.isPrime(i))
                    primes.Add(i);


        }
    }
}
