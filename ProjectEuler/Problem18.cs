using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	class Problem18: Solution
	{
		public void Solve()
		{
			int[][] array =
			{
				new int[]{75},
				new int[]{95,64},
				new int[]{17,47,82},
				new int[]{18,35,87,10},
				new int[]{20,04,82,47,65},
				new int[]{19,01,23,75,03,34},
				new int[]{88,02,77,73,07,63,67},
				new int[]{99,65,04,28,06,16,70,92},
				new int[]{41,41,26,56,83,40,80,70,33},
				new int[]{41,48,72,33,47,32,37,16,94,29},
				new int[]{53,71,44,65,25,43,91,52,97,51,14},
				new int[]{70,11,33,28,77,73,17,78,39,68,17,57},
				new int[]{91,71,52,38,17,14,91,43,58,50,27,29,48},
				new int[]{63,66,04,68,89,53,67,30,73,16,69,87,40,31},
				new int[]{04,62,98,27,23,09,70,98,73,93,38,53,60,04,23}
			};

			var solutionArray = new int[array.Length][]; //Declare an array to hold solutions
			solutionArray[0] = new int[1]; //Our first the Max cost of node 1 is trivially itself
			solutionArray[0][0] = array[0][0];  //Assign value 

			//for each row
			for (int i = 1; i < array.Length; i++)
			{
				solutionArray[i] = new int[i + 1];  //initialize the solution based on length of row
				for (int j = 0; j < array[i].Length; j++) //for row length
				{
					int parentSum; //will hold the sum of the optimal parent - most expensive

					//We can only have one parent in this case
					if (j == 0 || j == array[i].Length - 1) // if we are on a edge of the triangle
					{
						int indVal = (j == 0) ? j : j - 1; //determine if left or right
						parentSum = solutionArray[i - 1][indVal] + array[i][j]; //set parentsum to the optimal parent

					}
					else
					{
						//Take the greater of a child's two parents and add their optimal cost to the child's cost
						parentSum = (solutionArray[i - 1][j - 1] > solutionArray[i - 1][j])
											? solutionArray[i - 1][j - 1] + array[i][j]
											: solutionArray[i - 1][j] + array[i][j];
					}
					solutionArray[i][j] = parentSum; //put the optimal cost of the child in the solution
				}
			}
			//Print out the most costly solution
			Console.WriteLine("Solution for problem 18: {0}", solutionArray[solutionArray.Length - 1].Max());
		}
	}
}
