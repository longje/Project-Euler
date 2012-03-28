using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
	 * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
	 */

	class Problem5: Solution
	{
		public void Solve()
		{
			int curNum = 39;
			while (true)
			{
				if (isDivisible1to20(curNum))
					break;
				curNum++;
			}
			Console.WriteLine("Solution for problem 5: {0}", curNum);
		}

		private Boolean isDivisible1to20(int value)
		{
			for (int i = 1; i < 21; i++)
			{
				if (!(value % i == 0))
				{
					return false;
				}
			}
			return true;
		}
	}
}
