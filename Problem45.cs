﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * Triangle, pentagonal, and hexagonal numbers are generated by the following formulae:
			Triangle 	  	Tn=n(n+1)/2 	  	1, 3, 6, 10, 15, ...
			Pentagonal 	  	Pn=n(3n−1)/2 	  	1, 5, 12, 22, 35, ...
			Hexagonal 	  	Hn=n(2n−1) 	  	1, 6, 15, 28, 45, ...
	 * It can be verified that T285 = P165 = H143 = 40755.
	 * Find the next triangle number that is also pentagonal and hexagonal.
	 */
	class Problem45: Solution
	{
		public void Solve()
		{
			var triangleValues = from x in Enumerable.Range(1, 1000000)
								  select triangleNum(x);

			var pentagonalValues = from x in Enumerable.Range(1, 1000000)
								  select pentagonalNum(x);

			var hexagonalValues = from x in Enumerable.Range(1, 1000000)
								  select hexagonalNum(x);

			triangleValues = triangleValues
								.Intersect(pentagonalValues)
								.Intersect(hexagonalValues);

			Console.WriteLine("Solution for problem 45 is: {0}", triangleValues.Last());
		}

		private long pentagonalNum(int n)
		{
			return (n * (3L * n - 1L) / 2L);
		}

		private long hexagonalNum(int n)
		{
			return (n * (2L * n - 1L));
		}

		private long triangleNum(int n)
		{
			return (n * (n + 1L) / 2L);
		}
	}
}
