using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
	 * Find the sum of all the primes below two million.
	 */
	class Problem10: Solution
	{
		public void Solve()
		{
			var query = from n in ParallelEnumerable.Range(1, 2000000)
						where CustomMath.isPrime(n)
						select n;

			var result = query.ToList();
			var calc = CustomMath.Sum(result);

			Console.WriteLine("Solution for problem 3: {0}", calc);
		}
	}
}
