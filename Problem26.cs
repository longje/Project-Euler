using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * A unit fraction contains 1 in the numerator. The decimal representation of the unit fractions with denominators 2 to 10 are given:
		1/2	= 	0.5
		1/3	= 	0.(3)
		1/4	= 	0.25
		1/5	= 	0.2
		1/6	= 	0.1(6)
		1/7	= 	0.(142857)
		1/8	= 	0.125
		1/9	= 	0.(1)
		1/10	= 	0.1
	 * Where 0.1(6) means 0.166666..., and has a 1-digit recurring cycle. It can be seen that 1/7 has a 6-digit recurring cycle.
	 * Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.
	 */
	class Problem26: Solution
	{
		public void Solve()
		{
			var listOfStrings = new Dictionary<int, String>();

			for (int i = 2; i < 1000; i++)
				listOfStrings[i] = longDivision(1, i);

			var newlistOfStrings = listOfStrings
										.OrderByDescending(x => x.Value.Length)
										.ToDictionary(mc => mc.Key, mc => mc.Value.Length);

			Console.WriteLine("Longest recurring: {0} with a count of {1}", newlistOfStrings.First().Key, newlistOfStrings.First().Value);
		}

		static string longDivision(int num, int denom)
		{
			int i = 0;  //max number of digits
			string fraction = string.Empty;  //hold the fraction
			var remainders = new Dictionary<int, int>();  //key value of fraction length and remainder
			while (i < 1000)  //loop for 1000
			{
				num *= 10;  //bring down the "0" - 1/n
				int r = num % denom;  //determine remainder of division
				int q = num / denom;  //quotient is equal to number of times denominator goes into numerator

				if (r == 0)  //if the remainder is 0 we are done
					break;

				if (remainders.Values.Contains(r))  //if the remainder has already existed once
				{
					Boolean foundCycle = false;
					foreach (var item in remainders)  //loop through each remainder that has existed
					{
						var valtocomp = Int32.Parse(fraction[item.Key].ToString());  //take the length at the time of that remainder
						if (r == item.Value && q == valtocomp)  //if the current remainder is equal and the returned quotient value is equal to the fraction at the found remainder's fraction length
						{
							foundCycle = true;
							fraction += "(" + q + ")";
							break;
						}
					}
					if (foundCycle)
						break;
				}

				remainders[fraction.Length] = r;  //add the remainder value into the dictionary
				fraction += q;  //add the quotient to the running quotient
				num = r;  //assign the numerator the remainder value
				i++;  //increment count
			}
			return "0." + fraction;
		}
	}
}
