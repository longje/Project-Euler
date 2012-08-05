using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * n! means n × (n − 1) × ... × 3 × 2 × 1
	 * For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800,
	 * and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27.
	 * Find the sum of the digits in the number 100!
	 */ 
	class Problem20: Solution
	{
		public void Solve()
		{
			var x = CustomMath.factorial(100);
			var z = x.ToString().ToCharArray();
			var query = z.Sum(y => Int32.Parse(y.ToString()));
			Console.WriteLine("Solution for problem 20: {0}", query);
		}

	}
}
