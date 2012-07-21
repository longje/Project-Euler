using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * Let d(n) be defined as the sum of proper divisors of n (numbers less than n which divide evenly into n).
	 * If d(a) = b and d(b) = a, where a ≠ b, then a and b are an amicable pair and each of a and b are called amicable numbers.
	 * For example, the proper divisors of 220 are 1, 2, 4, 5, 10, 11, 20, 22, 44, 55 and 110; therefore d(220) = 284. The proper divisors of 284 are 1, 2, 4, 71 and 142; so d(284) = 220.
	 * Evaluate the sum of all the amicable numbers under 10000.
	 */
	class Problem21: Solution
	{
		public void Solve()
		{
			int i = 4;
			List<Amicable> sums = new List<Amicable>();

			while (i < 10000)
			{
				var result = new Amicable();
				result.number = i;

				for (int y = 1; y <= Math.Sqrt(i); y++)
				{
					if ((i % y) == 0)
					{
						result.product.Add(y);

						if (y != 1)
							result.product.Add(i / y);
					}
				}
				sums.Add(result);
				i++;
			}

			foreach (var item in sums)
			{
				if (item.sum < 10000)
				{
					checkIfAmicable(sums, item);
				}
			}

			List<Amicable> myResults = sums.Where(x => x.isAmicable).ToList();

			Console.WriteLine("Solution for problem 21: {0}", myResults.Sum(x => x.number));
		}

		public class Amicable
		{
			public int number;
			public List<int> product = new List<int>();
			public int sum { get { return product.Sum(); } }
			public Boolean isAmicable;
		}

		private void checkIfAmicable(List<Amicable> myList, Amicable value)
		{
			var y = myList.SingleOrDefault(x => (x.number == value.sum && x.number != x.sum));
			if (y != null)
				value.isAmicable = (y.number == value.sum && value.number == y.sum);
		}
	}
}
