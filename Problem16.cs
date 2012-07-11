using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
	/*
	 * 2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26.
	 * What is the sum of the digits of the number 2^1000?
	 */
	class Problem16: Solution
	{

		public void Solve()
		{
			BigInteger value = 1;
			for (int i = 1; i <= 1000; i++)
			{
				value *= 2;
			}

			var numbers = value.ToString();
			var array = numbers.ToCharArray();
			var query = array.Select(x => Int32.Parse(x.ToString())).Sum();

			Console.WriteLine("Solution for 16: {0}", query);
		}

	}
}
