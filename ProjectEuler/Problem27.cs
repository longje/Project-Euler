using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem27: Solution
    {
        public void Solve()
        {
            int n = 0;
            var theList = new List<Tuple<string, int>>();
            for (int a = -999; a < 1000; a++)
                for (int b = 1; b < 1000; b++)
                    if (CustomMath.isPrime(b))
                        theList.Add(Tuple.Create<string, int>(String.Format("n^2 + {0}*n + {1}", a, b), conseqQuadPrime(n, a, b)));

            Tuple<string, int> answer = Tuple.Create<string, int>(null, 0);
            foreach (var item in theList)
                if (item.Item2 > answer.Item2)
                    answer = item;

            Console.WriteLine(answer.Item1 + " " + answer.Item2);
        }

        private int conseqQuadPrime(int n, int a, int b)
        {
            int conseqPrimes = 1;
            while (conseqPrimes != 0)
            {
                var temp = n * n + a * n + b;
                if (CustomMath.isPrime(temp))
                {
                    conseqPrimes++;
                    n++;
                }
                else
                    break;
            }
            return conseqPrimes;
        }
    }
}
