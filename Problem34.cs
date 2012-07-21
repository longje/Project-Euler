using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * 145 is a curious number, as 1! + 4! + 5! = 1 + 24 + 120 = 145.
	 * Find the sum of all numbers which are equal to the sum of the factorial of their digits.
	 * Note: as 1! = 1 and 2! = 2 are not sums they are not included.
	 */
	class Problem34: Solution
	{
		public void Solve()
		{
			var sum = 0;
			for (int i = 3; i < 2540161; i++)
			{
				var array = i.ToString().ToCharArray();
				int x = 0;
				foreach (var item in array)
				{
					x += CustomMath.factorial(Int32.Parse(item.ToString()));
				}

				if (i == x)
					sum += x;
			}
			Console.WriteLine("Solution for problem 34: {0}", sum);	
		}
	}
}
