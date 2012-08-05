using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem41: Solution
    {
        public void Solve()
        {
            long i = 9999999L;
            for (; i > 1L; i -= 2)
                if (isPanDigital(i) && CustomMath.isPrime(i))
                    break;

            Console.WriteLine("Biggest pandigital prime: {0}", i);
        }

        private long[] putIntNumsIntoArray(long theInt)
        {
            long[] theArray = new long[numOfDigits(theInt)];

            for (long i = 1, j = 0; i < theInt; i *= 10, j++)
                theArray[j] = (theInt / i) % 10;

            return theArray;
        }

        private long numOfDigits(long theInt)
        {
            long someVal = 10;
            long numDigits = 1;
            while ((theInt / someVal) > 0)
            {
                numDigits++;
                someVal *= 10;
            }
            return numDigits;
        }

        private bool arrayContains(long i, long[] array)
        {
            for (int j = 0; j < array.Length; j++)
                if (array[j] == i)
                    return true;

            return false;
        }

        private Boolean isPanDigital(long n)
        {
            //Take result and put longo array
            long[] temp = putIntNumsIntoArray(n);

            //Are digits distinct and contain values 1 - 9?
            for (int i = 1; i <= temp.Length; i++)
               if (!arrayContains(i, temp))
                    return false;

            if (distinctCount(temp) == temp.Length)
                return true;

            return false;
        }

        private int distinctCount(long[] array)
        {
            int count = array.Length;
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] == array[j])
                        count--;
            return count;
        }
    }
}
