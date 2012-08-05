using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
	 * Find the largest palindrome made from the product of two 3-digit numbers.
	 */
	class Problem4: Solution
	{
		public void Solve()
		{
			var query = from i in Enumerable.Range(100, 999)
						from x in Enumerable.Range(100, 999)
						where determinePalindrome(i * x)
							&& i < 1000
							&& x < 1000
						let result = new { value = i * x, pal = String.Format("{0} * {1} = {2}", i, x, i * x) }
						orderby result.value
						select result;

			var results = query.ToList();

			Console.WriteLine("Solution for problem 4: {0}", results.Last().pal);
		}

		private Boolean determinePalindrome(int value)
		{
			String val = value.ToString();
			String revVal = val.reverseString();
			return val.Equals(revVal);
		}
	}
}
