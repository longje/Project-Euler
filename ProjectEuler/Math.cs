using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
	class CustomMath
	{
		public static int Power(int x, int y)
		{
			if (y == 0)
				return 1;

			if (y == 1)
				return x;

			return Power(x, --y) * x;
		}

		public static Boolean isPrime(long n)
		{
			double num = Math.Sqrt(n);
            if (n < 0) { return false; }
			if (n == 4d) { return false; }
			if (n == 1d) { return false; }

			for (double i = 2; i <= num; i++)
			{
				if (n % i == 0d)
				{
					return false;
				}
			}
			return true;
		}

		public static long Sum(List<int> list)
		{
			long myVal = 0;
			foreach (var item in list)
			{
				myVal += item;
			}
			return myVal;
		}

		public static BigInteger factorial(BigInteger x)
		{
			if (x < 2)
			{
				return 1;
			}
			return x * factorial(x - 1);
		}

        public static long factorial(long i)
        {
            return (i < 2)
                    ? 1
                    : i * factorial(--i);
        }

		public static int factorial(int i)
		{
			return (i < 2)
					? 1
					: i * factorial(--i);
		}

		public static Boolean isAbundant(int x)
		{
			var query = from y in Enumerable.Range(1, x / 2)
						where ((x % y) == 0)
						select y;
			var sum = query.Sum();
			return sum > x;
		}

		public static Boolean isCircularPrime(int num, int index, int orig, int[] circArray)
		{
			var cnum = orig.ToString();

			if (index > cnum.Length)
				return true;

			var sub = ((cnum.Length - 1) == index) ? cnum[index].ToString() : cnum.Substring(index);

			var other = cnum.Substring(0, index);
			var newNum = Int32.Parse(sub + other);
			var longNum = (long)newNum;
			if (isPrime(num) && isCircularPrime(newNum, index + 1, orig, circArray))
			{
				circArray[newNum] = 1;
				circArray[num] = 1;
				return true;
			}
			else
			{
				return false;
			}

		}

        internal static bool isAPermutation(int orig, int comp)
        {
            var x = orig.ToString();
            var y = comp.ToString();

            if (distinctCount(x) != distinctCount(y))
                return false;

            return antiJoin(x, y).Length == 0;
        }

        internal static string antiJoin(string x, string y)
        {
            string temp = String.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                int j = 0;
                for (; j < y.Length; j++)
                    if (x[i] == y[j])
                        break;
                if (j == x.Length)
                    temp += x[i];

            }
            return temp;
        }

        internal static int distinctCount(string x)
        {
            int count = x.Length;
            for (int i = 0; i < x.Length - 1; i++)
                for (int j = i + 1; j < x.Length; j++)
                    if (x[i] == x[j])
                        count--;
            return count;
        }


	}
}
