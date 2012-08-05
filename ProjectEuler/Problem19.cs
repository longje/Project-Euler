using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	/*
	 * You are given the following information, but you may prefer to do some research for yourself.
			1 Jan 1900 was a Monday.
			Thirty days has September,
			April, June and November.
			All the rest have thirty-one,
			Saving February alone,
			Which has twenty-eight, rain or shine.
			And on leap years, twenty-nine.
			A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
	 * How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
	 */

	class Problem19: Solution
	{
		public void Solve()
		{
			int startYear = 1901;
			int endYear = 2001;
			Dictionary<String, int> months = new Dictionary<string, int>
			                {
			                    {"jan", 31},
			                    {"feb", 28},
			                    {"march", 31},
			                    {"april", 30},
			                    {"may", 31},
			                    {"june", 30},
			                    {"july", 31},
			                    {"aug", 31},
			                    {"sept", 30},
			                    {"oct", 31},
			                    {"nov", 30},
			                    {"dec", 31}
			                };

			List<Sundays> results = new List<Sundays>();
			int carry = 6;

			while (startYear < endYear)
			{
				foreach (var item in months)
				{
					int startDay = carry;
					int days = item.Value;

					if (item.Key.Equals("feb") && (((startYear % 4) == 0) || startYear == 2000))
					{
						days = 29;
					}

					while (startDay <= days)
					{
						results.Add(new Sundays
						{
							date = startDay,
							month = item.Key,
							year = startYear,
						});
						startDay = startDay + 7;
					}
					carry = startDay % days;
				}
				startYear++;
			}

			int total = results.Where(x => x.date == 1).Count();
			List<Sundays> myList = results.Where(x => x.date == 1).ToList();
			Sundays lastSunday = results.Last();
			Console.WriteLine("Solution for problem 21: {0}", total);
		}

		public class Sundays
		{
			public int date;
			public String month;
			public int year;
		}
	}


}
