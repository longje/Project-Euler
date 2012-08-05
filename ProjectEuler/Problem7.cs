using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
	 * What is the 10 001st prime number?
	 */

	class Problem7: Solution
	{
		public void Solve()
		{
			var myList = new List<double>();
			for (int i = 2; myList.Count < 10001; i++)
			{
				if (CustomMath.isPrime(i))
					myList.Add(i);
			}
			Console.WriteLine("Solution for 7: {0}", myList.Last());
		}
	}
}
