using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
		/*
		 * If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
		 * If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used? 
		 * NOTE: Do not count spaces or hyphens. For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one 
		 * hundred and fifteen) contains 20 letters. The use of "and" when writing out numbers is in compliance with British usage.
		 * class Problem17: Solution
		 */
	public class Problem17:Solution
	{
		public void Solve()
		{
			var numbersSpelled = new Dictionary<int, String>
			                        {   {1, "one"},
			                            {2, "two"},
			                            {3, "three"},
			                            {4, "four"},
			                            {5, "five"},
			                            {6, "six"},
			                            {7, "seven"},
			                            {8, "eight"},
			                            {9, "nine"},
			                            {10, "ten"},
			                            {11, "eleven"},
			                            {12, "twelve"},
			                            {13, "thirteen"},
			                            {14, "fourteen"},
			                            {15, "fifteen"},
			                            {16, "sixteen"},
			                            {17, "seventeen"},
			                            {18, "eighteen"},
			                            {19, "nineteen"},
			                            {20, "twenty"},
			                            {30, "thirty"},
			                            {40, "forty"},
			                            {50, "fifty"},
			                            {60, "sixty"},
			                            {70, "seventy"},
			                            {80, "eighty"},
			                            {90, "ninety"},
			                            {100, "hundred"}};

			var query = from x in Enumerable.Range(1, 1000)
						let b = convertNumberToWord(numbersSpelled, x)
						let c = b.Count()
						select new
						{
							Number = x,
							Worded = b,
							WordCount = c
						};

			var list = query.ToList();
			Console.WriteLine("Solution for problem 17: {0}", query.Sum(x => x.WordCount));
		}

		static String convertNumberToWord(Dictionary<int, String> dictionary, int value)
		{
			var stringVal = value.ToString();
			var array = stringVal.ToCharArray();
			String constructedString = "";

			if (value < 21)
			{
				return dictionary[value];
			}

			if (value == 1000)
				return "onethousand";

			for (int i = 0; i < array.Length; i++)
			{
				int val = Int32.Parse(array[i].ToString());

				if (array.Length - i == 3 && dictionary.ContainsKey(val))
				{
					if (array[i + 1].Equals('0') && array[i + 2].Equals('0'))
					{
						return dictionary[val] + dictionary[100];
					}

					constructedString += dictionary[val] + "hundredand";
				}
				else if (array.Length - i == 2 && dictionary.ContainsKey(val) && val == 1)
				{
					var determinedOne = Int32.Parse(array[i + 1].ToString());
					var temp = Int32.Parse(val.ToString() + determinedOne.ToString());
					constructedString += dictionary[temp];
					return constructedString;
				}
				else if (array.Length - i == 2 && dictionary.ContainsKey(val))
				{
					val = Int32.Parse(array[i].ToString() + "0");
					constructedString += dictionary[val];
				}
				else if (array.Length - i == 1 && dictionary.ContainsKey(val))
				{
					constructedString += dictionary[val];
				}
			}

			return constructedString;
		}
	}
}
