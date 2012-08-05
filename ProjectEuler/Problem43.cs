using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem43: Solution
    {
        private void printArray(long[] x)
        {
            foreach (var item in x)
            {
                Console.Write(item); 
            }
            Console.WriteLine();
        }

        private bool isSumOk(long[] x)
        {
            long sum = 0;
            for (long i = 0; i < x.Length; i++)
                sum += x[i];
            return sum == 45;
        }

        public void Solve()
        {
            long initial = 1400000000;
            long[] temp = putIntNumsIntoArray(initial);
            long runningSum = 0;
            //Console.WriteLine("{0} is Pandigital and has SubStringProp?  {1}", 1406357289L, isPanDigital(temp) && hasSubStringDivisibilityProperty(temp));
            for (long i = initial; i < 9999999999; i++)
            {
                //var temp = putIntNumsIntoArray(i);
                if (!isSumOk(temp))
                {
                    incrementBy1(temp);
                    continue;
                }

                if (isPanDigital(temp) && hasSubStringDivisibilityProperty(temp))
                {
                    Console.WriteLine("{0} is Pandigital and has substring property", i);
                    runningSum += i;
                }

                incrementBy1(temp);
            }
            Console.WriteLine("{0} is the running sum", runningSum);
        }

        private void incrementBy1(long[] x)
        {
            int i = 9;
            while (x[i] == 9)
                x[i--] = 0;
            x[i]++;
        }

        private bool hasSubStringDivisibilityProperty(long[] n)
        {
            long[] k = {2, 3, 5, 7, 11, 13, 17};
            for(int i = 1; i < 8; i++)
                if ( ! isDivisibleBy( arrayToNum(n[i], n[i+1], n[i+2]), k[i-1]) )
                    return false;
            return true;
        }

        private bool isDivisibleBy(long i, long div)
        {
            return (i % div == 0);
        }

        private long arrayToNum(long i, long j, long k)
        {
            long result = i * 100L;
            result += j * 10L;
            result += k;
            return result;
        }

        private Boolean isPanDigital(long[] temp)
        {
            //Take result and put longo array
            //long[] temp = n;

            //Are digits distinct and contain values 0 - 9?
            for (int i = 0; i < temp.Length; i++)
                if (!arrayContains(i, temp))
                    return false;

            //if (distinctCount(temp) == temp.Length)
            //    return true;

            return true;
        }

        private long[] putIntNumsIntoArray(long theInt)
        {
            long[] theArray = new long[10];

            for (long i = 1, j = 0; i < theInt; i *= 10, j++)
                theArray[9 - j] = (theInt / i) % 10;

            return theArray;
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
    }
}
