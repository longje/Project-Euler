using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem92: Solution
    {
        const long endValue = 89;
        const long otherEndValue = 1;

        public void Solve()
        {
            int total = 0;
            for (long i = 2; i < 10000000; i++)
            {
                var holder = putIntNumsIntoArray(i);
                var sum = sumOfSquares(holder);
                while (sum != otherEndValue)
                {
                   sum = sumOfSquares(putIntNumsIntoArray(sum));
                   if (sum == endValue)
                   {
                       total++;
                       break;
                   }
                }
            }
            Console.WriteLine("The total number of 89s is {0}", total);

        }

        private long sumOfSquares(long[] value)
        {
            long sum = 0;
            foreach (var x in value)
                sum += CustomMath.Power((int)x, 2);
            return sum;
        }

        private long[] putIntNumsIntoArray(long theInt)
        {
            long[] theArray = new long[10];

            for (long i = 1, j = 0; i <= theInt; i *= 10, j++)
                theArray[9 - j] = (theInt / i) % 10;

            return theArray;
        }
    }
}
