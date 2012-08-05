using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem38: Solution
    {
        public void Solve()
        {
            long biggest = 0;
            for (long x = 1; x < 10000; x++)
            {
                long i = 1;
                string stringProd = "";
                while (true)
                {
                    stringProd += (x * i++).ToString();
                    long temp = Int64.Parse(stringProd);

                    if (temp > 999999999)
                        break;

                    if (temp > biggest && isPanDigital(temp))
                    {
                        biggest = temp;
                        Console.Write(String.Format("{0} * {1} = {2}\n", x, i - 1, temp));
                    }
                }
            }

            Console.WriteLine(biggest);
        }

        private List<Tuple<long, long>> getProducts(long num)
        {
            List<Tuple<long, long>> theList = new List<Tuple<long, long>>();
            long theRoot = (long)Math.Sqrt(num);
            for (long i = 2; i < theRoot; i++)
            {
                if ((num % i) == 0)
                    theList.Add(Tuple.Create(i, num / i));
            }
            return theList;
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

        private Boolean isPanDigital(long n)
        {
            String numbers = n.ToString();

            //Exit if resulting value isn't 9 digits
            if (numbers.Length != 9)
                return false;

            //Take result and put longo array
            long[] temp = putIntNumsIntoArray(Int32.Parse(numbers));

            //Are digits distinct and contain values 1 - 9?
            if (distinctCount(temp) == 9
                    && temp.Sum() == 45)
                return true;

            return false;
        }

        private long distinctCount(long[] array)
        {
            long count = (long)array.Length;
            for (long i = 0; i < array.Length - 1; i++)
                for (long j = i + 1; j < array.Length; j++)
                    if (array[i] == array[j])
                        count--;
            return count;
        }
    }
}
