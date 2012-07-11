using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
	 * Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
	 * (Please note that the palindromic number, in either base, may not include leading zeros.)
	 */
	class Problem36: Solution
	{
		int[] binVals = (from x in Enumerable.Range(0, 30)
					 select CustomMath.Power(2, x)).ToArray();

		public void Solve()
		{
			var query = from x in Enumerable.Range(1, 1000000)
						where determinePalindrome(x) && determinePalindrome(convertIntToBin(x))
						select x;

			Console.WriteLine("Solution for Problem 36 is : {0}", query.Sum());
		}

		//My greedy approach for converting an int to its binary form
		private String convertIntToBin(int value)
		{
			int runningValue = value;

			string bin = "";
			Boolean startBin = false;
			var div = new List<int>();

			for (int i = binVals.Length - 1; i > -1; i--)
			{
				if (binVals[i] <= runningValue)
				{
					bin += 1;
					startBin = true;
					div.Add(binVals[i]);
					runningValue -= binVals[i];
				}
				else if (startBin)
					bin += 0;
			}
			return bin;
		}

		private Boolean determinePalindrome(string value)
		{
			String val = value;
			String revVal = val.reverseString();
			return val.Equals(revVal);
		}

		private Boolean determinePalindrome(int value)
		{
			String val = value.ToString();
			String revVal = val.reverseString();
			return val.Equals(revVal);
		}
	}
}
