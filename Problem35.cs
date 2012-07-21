using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * The number, 197, is called a circular prime because all rotations of the digits: 197, 971, and 719, are themselves prime.
	 * There are thirteen such primes below 100: 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, and 97.
	 * How many circular primes are there below one million?
	 */
	class Problem35: Solution
	{
		public void Solve()
		{
			var circArray = new int[1000000];

			for (int i = 1; i < 1000000; i++)
			{
				if (i < 10 && CustomMath.isPrime(i))
				{
					circArray[i] = 1;
					continue;
				}

				if (circArray[i] == 1)
					continue;

				CustomMath.isCircularPrime(i, 1, i, circArray);
			}

			Console.WriteLine("Solution for problem 35: {0}", circArray.Count(x => x == 1));
		}
	}
}
