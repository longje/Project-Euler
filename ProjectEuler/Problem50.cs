using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem50: Solution
    {
        List<int> primes = new List<int>();
        int[,] results; 

        public void Solve()
        {
           int runningSum = 0;
           for (int i = 2; runningSum < 1000000; i++)
           {
               if (CustomMath.isPrime(i))
               {
                   primes.Add(i);
                   runningSum += i;
               }
           }

           results = new int[primes.Count,primes.Count];
           for (int i = 0; i < primes.Count; i++)
           {
               for (int j = i; j < primes.Count; j++)
               {
                   if (i == j)
                       results[i, j] = primes[i];
                   else
                       results[i, j] = primes[j] + results[i, j - 1];
               }
           }

            /*
           for (int i = 0; i < primes.Count; i++)
           {
               for (int j = 0; j < primes.Count; j++)
                   Console.Write(" {0} ", results[i, j]);

               Console.WriteLine();
           }
            */
           var temp = getBiggestPrime(results);
           Console.WriteLine("Biggest Prime is {0} with {1} consecutive primes", temp.Item2, temp.Item1);
        }

        private int getConsecCount (int[,] array, int i, int j)
        {
            int cons = 0;
            while (j > -1 && array[i, j--] != 0)
                cons++;
            return cons;
        }

        private Tuple<int, int> getBiggestPrime(int[,] array)
        {
            int cons = 0;
            int prime = 0;
            for (int i = (primes.Count - 1); i > -1; i--)
                for (int j = (primes.Count - 1); j > -1; j--)
                    if (array[i,j] < 1000000 
                            && array[i, j] != 0 
                            && CustomMath.isPrime(array[i, j])
                            && getConsecCount(array, i, j) > cons)
                    {
                        cons = getConsecCount(array, i, j);
                        prime = array[i, j];
                    }
            return Tuple.Create<int, int>(cons, prime);
        }
    }
}
