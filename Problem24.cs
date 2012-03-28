using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace ProjectEuler
{
	/*
	 * A permutation is an ordered arrangement of objects. For example, 3124 is one possible permutation of the digits 1, 2, 3 and 4. If all of the permutations are listed numerically or alphabetically, we call it lexicographic order. The lexicographic permutations of 0, 1 and 2 are:
			012   021   102   120   201   210
	 * What is the millionth lexicographic permutation of the digits 0, 1, 2, 3, 4, 5, 6, 7, 8 and 9?
	 */
	class Problem24: Solution
	{
		int[] choices = Enumerable.Range(0, 10).ToArray();
		string[] newChoices = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

		public void Solve()
		{
			string[,] c;

			for (int z = 0; z < 9; z++)
			{
				c = new string[newChoices.Length, choices.Length];
				for (int i = 0; i < newChoices.Length; i++)
				{
					for (int j = 0; j < choices.Length; j++)
					{
						if (newChoices[i].Contains(choices[j].ToString()))
							continue;

						c[i, j] = newChoices[i].ToString() + choices[j].ToString();
					}
				}
				newChoices = flattenArray(c);
			}

			Console.WriteLine("Solution for problem 24: {0} - Total Count: {1}", newChoices[999999], newChoices.Count());
		}

		private string[] flattenArray(string[,] array)
		{
			int newSize = array.Length;
			List<string> theNewChoices = new List<string>(newSize);
			for (int i = 0; i < newChoices.Length; i++)
			{
				for (int j = 0; j < choices.Length; j++)
				{
					if (array[i, j] != null)
						theNewChoices.Add(array[i, j]);
				}
			}
			return theNewChoices.ToArray();
		}
	}
}
