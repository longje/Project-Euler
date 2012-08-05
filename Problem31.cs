using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	class Problem31: Solution
	{
		public void Solve()
		{
			int[] denominations = { 1, 2, 5, 10, 20, 50, 100, 200 };
			//List<int[]> results = new List<int[]>();

			//results.Add(new int[] { 1, 1, 1, 1, 1, 1, 1, 1 });

			int[] results = new int[201];
			results[0] = 1;
			foreach (var j in denominations)
				for (int i = j; i < 201; i++)
					results[i] += results[i - j];

			Console.WriteLine("{0}", results[200]);
		}
	}
}
