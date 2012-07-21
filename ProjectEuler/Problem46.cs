using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem46: Solution
    {
        List<long> primes = new List<long>(1000);
        List<long> squares = new List<long>(1000);

        public void Solve()
        {
            squares.Add(1);
            long i = 3;
            for (; ; i += 2)
            {
                squares.Add((i - 1) * (i - 1));
                squares.Add(i * i);
                if (CustomMath.isPrime(i))
                    primes.Add(i);
                else if (!isGoldbach(i))
                    break;
            }
            Console.WriteLine("{0} is an odd composite that doesn't fit Goldbach conjecture.", i);
        }

        private bool isInSquare(long key)
        {
            int begin = 0;
            int end = squares.Count();
            while (end >= begin)
            {
                int mid = (end + begin) >> 1;

                if (squares[mid] < key)
                    begin = mid + 1;
                else if (squares[mid] > key)
                    end = mid - 1;
                else
                    return true;
            }
            return false;
        }

        private bool isASquare(long n)
        {
            return isInSquare(n);
            /*
            var temp = Math.Sqrt(n);
            return ( temp - ((long)temp) ) == 0.0;
             */
        }

        private bool isGoldbach(long n)
        {
            foreach (var x in primes)
                if (isASquare( (n - x) >> 1 ))
                    return true;
            return false;
        }
    }
}
