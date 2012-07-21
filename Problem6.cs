using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	class Problem6: Solution
	{
		public void Solve()
		{
			var sumOfSquares = from x in Enumerable.Range(1, 100)
							   select x * x;
			var sumValue = sumOfSquares.Sum();
			var squareOfSum = Enumerable.Range(1, 100).Sum();
			var squareValue = squareOfSum * squareOfSum;
			Console.WriteLine("Solution for problem 6: {0}", squareValue - sumValue);
		}
	}
}
