using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * Surprisingly there are only three numbers that can be written as the sum of fourth powers of their digits:
	 *	    1634 = 14 + 64 + 34 + 44
	 *		8208 = 84 + 24 + 04 + 84
	 *		9474 = 94 + 44 + 74 + 44
	 * As 1 = 14 is not a sum it is not included.
	 * The sum of these numbers is 1634 + 8208 + 9474 = 19316.
	 * Find the sum of all the numbers that can be written as the sum of fifth powers of their digits.
	 */

	class Problem30: Solution
	{
		public void Solve()
		{
			var y = 0;
			for (int i = 2; i < 1000000; i++)
			{
				var array = i.ToString().ToCharArray();
				int x = 0;
				foreach (var item in array)
					x += fifthPower(Int32.Parse(item.ToString()));

				if (i == x)
					y += x;
			}

			Console.WriteLine("Solution for problem 30: {0}", y);
		}

		int fifthPower(int i)
		{
			return (i < 1)
					? 0
					: i * i * i * i * i;
		}
	}
}
