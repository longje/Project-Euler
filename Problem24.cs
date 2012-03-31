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
		string[] origChoices = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
		string[] newChoices;

		public void Solve()
		{
			newChoices = origChoices;
			int count = 0;
			string[,] c;
			
			for (int z = 0; z < 9; z++)
			{
				c = new string[newChoices.Length, origChoices.Length];
				count = 0;
				for (int i = 0; i < newChoices.Length; i++)
				{
					for (int j = 0; j < origChoices.Length; j++)
					{
						if (newChoices[i].Contains(origChoices[j]))
							continue;

						c[i, j] = newChoices[i] + origChoices[j];
						count++;
					}
				}
				newChoices = flattenArray(c, count);
			}

			Console.WriteLine("Solution for problem 24: {0} - Total Count: {1}", newChoices[999999], count);
		}

		private string[] flattenArray(string[,] array, int size)
		{
			string[] theNewChoices = new string[size];
			int count = 0;
			for (int i = 0; i < newChoices.Length; i++)
			{
				for (int j = 0; j < origChoices.Length; j++)
				{
					if (array[i, j] != null)
						theNewChoices[count++] = array[i, j];
				}
			}
			return theNewChoices;
		}
	}
}
