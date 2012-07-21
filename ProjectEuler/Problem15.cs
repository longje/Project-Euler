using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	class Problem15: Solution
	{
		/*
		 * Starting in the top left corner of a 2×2 grid, there are 6 routes (without backtracking) to the bottom right corner.
		 * How many routes are there through a 20×20 grid?
		 */

		public void Solve()
		{
			long[,] x = new long[20, 20];

			for (int i = 0; i < 20; i++)
			{
				x[0, i] = i + 2;
				x[i, 0] = i + 2;
			}

			for (int i = 1; i < 20; i++)
			{
				for (int j = 1; j < 20; j++)
				{
					x[i, j] = x[i, j - 1] + x[i - 1, j];
				}
			}

			Console.WriteLine("Solution for problem 15 : {0}", x[19, 19]);
		}
	}
}
