using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/* The following iterative sequence is defined for the set of positive integers:
	 * n → n/2 (n is even)
	 * n → 3n + 1 (n is odd)
	 * Using the rule above and starting with 13, we generate the following sequence:
	 * 13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1
	 * It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1.
	 * Which starting number, under one million, produces the longest chain?
	 * NOTE: Once the chain starts the terms are allowed to go above one million.
	*/
	class Problem14: Solution
	{
		//Collatz Theorem - http://en.wikipedia.org/wiki/Collatz_conjecture
		//n →  n/2 (n is even)
		//n → 3n + 1 (n is odd)

		public void Solve()
		{
			var value = (from x in Enumerable.Range(1, 1000000)
						 let b = runSequence(x)
						 orderby b.Steps descending
						 select b).First();

			Console.WriteLine(value.Number);
			Console.WriteLine(value.Steps);
		}

		private result runSequence(int v)
		{
			long[] results = new long[1000001];
			long count = 0;
			long value = v;

			if (results[value] != 0)
				return new result { Steps = results[value], Number = value };

			while (value != 1)
			{
				value = mySequence(value);
				count++;
				if (value < results.Length && results[value] != 0)
				{
					results[v] = results[value] + count;
					return new result { Steps = results[value] + count, Number = v };
				}

			}
			results[v] = count;
			return new result { Steps = count, Number = v }; ;
		}

		static long mySequence(long value)
		{
			return (value % 2 == 0)
				? value / 2
				: 3 * value + 1;
		}
	}
	
	public class result
	{
		public long Steps;
		public long Number;
	}
}
