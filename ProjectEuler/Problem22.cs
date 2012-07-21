using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectEuler
{
	/*
	 * Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
	 * For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714.
	 * What is the total of all the name scores in the file?
	 */
	class Problem22: Solution
	{
		char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

		public void Solve()
		{
			var names = (from line in File.ReadAllLines("../../text/names.txt")
						 select line.Split(','))
						.Single()
						.OrderBy(x => x)
						.ToArray();

			var val = 0;
			for (int i = 0; i < names.Length; i++)
			{
				val += nameValue(names[i]) * (i + 1);
			}

			Console.WriteLine("Solution for problem 22: {0}", val);
		}

		private int nameValue(string name)
		{
			var charName = name.ToCharArray();
			var query = from x in charName
						let z = alphaValue(x)
						select z;
			return query.Sum();
		}

		private int alphaValue(char letter)
		{
			int value = 0;
			for (int i = 0; i < alpha.Length; i++)
			{
				if (alpha[i] == letter)
				{
					value = i + 1;
					break;
				}
			}
			return value;
		}

	}
}
