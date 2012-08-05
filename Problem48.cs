using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
	class Problem48: Solution
	{

		public void Solve()
		{
			var query = (from x in Enumerable.Range(1, 500)
						select (Math.Pow(x, x))).ToList();

			var result = new BigInteger(0);
			foreach (var item in query)
			{
				//result += item;
			}

			Console.WriteLine(result);
		}

	}
}
