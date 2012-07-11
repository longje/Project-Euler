using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * Starting with the number 1 and moving to the right in a clockwise direction a 5 by 5 spiral is formed as follows:
			21 22 23 24 25
			20  7  8  9 10
			19  6  1  2 11
			18  5  4  3 12
			17 16 15 14 13
	 * It can be verified that the sum of the numbers on the diagonals is 101.
	 * What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?
	 */
	class Problem28: Solution
	{
		public void Solve()
		{
			int n = 7;
			int countDiag = n + n - 1;
			int runningNum = 1; //actual number we are at
			int sum = 1; //running total based on pattern
			int numToSkip = 2; //how many numbers we should skip
			int breakingPoint = 0; //when to skip
			List<int> nums = new List<int>(countDiag); //For recreating the matrix

			while (nums.Count() + 1 < countDiag)
			{
				runningNum += numToSkip;
				nums.Add(runningNum);

				//4 numbers will be included per row | col
				if (++breakingPoint == 4)
				{
					numToSkip += 2;
					breakingPoint = 0;  //reset breaking point
				}
			}

			Console.WriteLine("Solution for Problem 28 is: {0}", sum);
	 

			int[,] t = new int[n, n];
			int sizeOf = n - 1;

			//fill in diagonals
			for (int diagNum = nums.Count - 1, i = sizeOf, j = 0; ; i--, j++)
			{
				if (diagNum < 3)
				{
					t[i, j] = 1;
					break;
				}
				
				t[i, i] = nums[diagNum--];
				t[i, j] = nums[diagNum--];

				t[j, j] = nums[diagNum--];
				t[j, i] = nums[diagNum--];
			}

			//fill in matrix
			for (int i = sizeOf, c = 0; i > 1; i--, c++)
			{
				for (int j = i - 1; j > sizeOf - i; j--)
					t[i, j] = t[i, i] - i + j;

				for (int j = c + 1; j < sizeOf - c; j++)
					t[c, j] = t[c, c] - j + c;

				for (int j = c + 1; j < i; j++)
					t[j, i] = t[c, i] - j + c;

				for (int j = i - 1; j > c; j--)
					t[j, c] = t[i, c] - i + j;
			}
	
			for (int i = sizeOf; i > -1; i--)
			{
				Console.Write(" {0}\t", t[i, 0]);
				for (int j = 1; j < n; j++)
				{
					Console.Write("{0}\t", t[i, j]);
				}
				Console.WriteLine();
			}


			Console.WriteLine();

		}

		private Boolean isOdd(int n)
		{
			return (n % 2) != 0;
		}
	}
}
