using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
	/*
	 * The Fibonacci sequence is defined by the recurrence relation:
	 * Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1.
	 * Hence the first 12 terms will be:
			F1 = 1
			F2 = 1
			F3 = 2
			F4 = 3
			F5 = 5
			F6 = 8
			F7 = 13
			F8 = 21
			F9 = 34
			F10 = 55
			F11 = 89
			F12 = 144
	 * The 12th term, F12, is the first term to contain three digits.
	 * What is the first term in the Fibonacci sequence to contain 1000 digits?
	 */
	class Problem25: Solution
	{
		delegate BigInteger myDelegate(ref BigInteger[] g);

		public void Solve()
		{
			BigInteger total = 0;
			var temp = new BigInteger[] { 0, 1 };

			myDelegate add2AndSwap =
				(ref BigInteger[] g) =>
				{
					var newVal = g[1] + g[0];
					g[0] = g[1];
					g[1] = newVal;

					if (((newVal % 2) == 0))
					{
						total += newVal;
					}

					return newVal;
				};
			// Modified to solve Euler problem 25
			// First term in Fibonacci sequence to contain 1000 digits - 4782

			var x = from z in Enumerable.Range(0, 9999)
					let fi = add2AndSwap(ref temp)
					where fi.ToString().Length > 999
					select new
					{
						fib = fi,
						sequence = z + 2,
					};

			var value = x.OrderBy(y => y.sequence).First();
			Console.WriteLine("Solution for problem 25: {0}", value.sequence);
		}
	}
}
