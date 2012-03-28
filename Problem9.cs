using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
	 * a2 + b2 = c2
	 * For example, 32 + 42 = 9 + 16 = 25 = 52.
	 * There exists exactly one Pythagorean triplet for which a + b + c = 1000.
	 * Find the product abc.
	 */

	class Problem9: Solution
	{
		public void Solve()
		{
			double a = 0;
			double b = 0;
			double c = findC(a, b);

			var query = from e in Enumerable.Range(1, 500)
						from x in Enumerable.Range(1, 500)
						let cVal = findC(e, x)
						let cFactor = findFactor(cVal)
						where cFactor <= 800
								&& cFactor > 0
								&& ((cFactor + e + x) == 1000)
						select
							new
							{
								a = e,
								b = x,
								c = cFactor
							};
			Console.WriteLine("Solution for problem 9: {0}", query.Last());
		}
		
		private double findC(double a, double b)
		{
			return a * a + b * b;
		}

		private double findFactor(double val)
		{
			for (int i = 0; i < val / 2; i++)
			{
				if ((i * i) == val)
					return i;
			}
			return 0;
		}
	}
}
