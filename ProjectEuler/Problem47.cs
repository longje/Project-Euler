using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    /*
     * Check out Sieve of Eratosthenes for fast solution!
     * http://en.wikipedia.org/wiki/Sieve_of_Eratosthenes
     */
    class Problem47: Solution
    {
        public void Solve()
        {
            var results = new List<Tuple<long, long, long, long, long>>();
            for (int i = 1; i < 135000 ; i++)
            {
                var temp = getPrimeFactors4(getProducts4(i), i);
                if (temp != null)
                {
                    results.Add(temp);
                    if (consecutive(results))
                        break;
                }
            }
            /*
            GetPrimeFactors(134043);
            int n = 0;
            for (int i = 648; ; i++)
            {
                if (GetPrimeFactors(i).Length == 4)
                    n++;
                else
                    n = 0;
                if (n == 4)
                {
                    Console.WriteLine("First number: " + (i - 3));
                    break;
                }
            }
             */
        }

        public static int[] GetPrimeFactors(int number)
        {
            if (number <= 3)
                return new int[] { number };
            var divs = new LinkedList<int>();
            if ((number & 1) == 0)
            {
                divs.AddLast(2);
                while (((number /= 2) & 1) == 0) ;
            }
            int max = (int)Math.Sqrt(number);
            for (int i = 3; i <= max; i += 2)
            {
                if (number % i == 0)
                {
                    divs.AddLast(i);
                    while ((number /= i) % i == 0) ;
                    max = (int)Math.Sqrt(number);
                }
            }
            if (number > 1)
                divs.AddLast(number);
            return divs.ToArray<int>();
        }

        private bool consecutive(List<Tuple<long, long, long, long, long>> theList)
        {
            int count = 1;
            int i;

            if (theList.Count < 7)
                return false;

            for (i = theList.Count - 6; i < theList.Count-1; i++)
            {
                count = ((theList[i].Item5 == (theList[i + 1].Item5 - 1)))
                            ? count + 1
                            : 1;
            }

            if (count < 4)
                return false;

            for (int x = 0; x < 4; x++, i--)
                Console.WriteLine("{0} x {1} x {2} x {3} = {4}", theList[i].Item1, theList[i].Item2, theList[i].Item3, theList[i].Item4, theList[i].Item5);

            return true;
        }

        private bool isPrimeSquared (long n)
        {
            var temp = Math.Sqrt(n);
            if ((temp - (long)temp) != 0)
                return false;

            return CustomMath.isPrime((long)temp);
        }

        private bool isItemDivisArray(Tuple<long, long, long, long> x, long n)
        {
            long[] array = { x.Item1, x.Item2, x.Item3, x.Item4 };
            for (int j = 0; j < array.Length - 1; j++)
                for (int k = j + 1; k < array.Length; k++)
                    if ((array[k] % array[j]) == 0)
                        return true;
            return false;
        }

        private Tuple<long, long, long, long, long> getPrimeFactors4(List<Tuple<long, long, long, long>> theList, long i)
        {
            foreach (var x in theList)
                if ((CustomMath.isPrime(x.Item3) || isPrimeSquared(x.Item3))
                         && (CustomMath.isPrime(x.Item4) || isPrimeSquared(x.Item4))
                         && !isItemDivisArray(x, i))
                    return Tuple.Create<long, long, long, long, long>(x.Item1, x.Item2, x.Item3, x.Item4, i);
            return null;
        }

        private List<Tuple<long, long, long, long>> getProducts4(long num)
        {
            List<Tuple<long, long, long, long>> theList = new List<Tuple<long, long, long, long>>();

            var max2 = (long)Math.Pow(num, (1.0/3.0));
            var max3 = (long)Math.Pow(num, (1.0/6.0));
            var max = (long)Math.Sqrt(num);

            for (long i = 2; i <= max3; i++)
            {
                if ( !(CustomMath.isPrime(i) || isPrimeSquared(i)))
                    continue;
                for (long j = i + 1; j <= max2; j++)
                {
                    if (!(CustomMath.isPrime(j) || isPrimeSquared(j)))
                        continue;
                    for (long k = j + 1; k <= max2; k++)
                    {
                        if (((num % (i * j * k)) == 0))
                        {
                            var x = (num / (i * j * k));
                            theList.Add(Tuple.Create(i, j, k, x));
                        }
                    }
                }
            }
            return theList;
        }
    }
}
