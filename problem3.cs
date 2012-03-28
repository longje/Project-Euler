using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * The prime factors of 13195 are 5, 7, 13 and 29.
	 * What is the largest prime factor of the number 600851475143 ?
	 */
	class problem3 : Solution
	{
		private List<long> factors = new List<long>();

		public void Solve()
		{
			getPrimeFactors(600851475143);
			factors.Sort();
			Console.WriteLine("Solution for problem 3: {0}", factors.Last());
		}

		private void getPrimeFactors(long n)
		{
			if (n == 0 || n == 1) return;

			long divisor = 0;

			//Find smallest divisor for a given number
			for (long i = 2; i * i <= n; i++)
			{
				if (n % i == 0)
				{
					divisor = i;
					break;
				}
			}

			//No divisor so n is prime
			if (divisor == 0)
			{
				factors.Add(n);
				return;
			}

			//Repeat to get factors for given number
			getPrimeFactors(n / divisor);
		}
	}
}
