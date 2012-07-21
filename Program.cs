using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Diagnostics;

namespace ProjectEuler
{
	class Program
	{
		static void Main(string[] args)
		{
			var ListOfProblems
				= new List<Solution>()
				{
					new problem3(),
					new Problem4(),
					new Problem5(),
					new Problem6(),
					new Problem7(),
					new Problem8(),
					new Problem9(),
					new Problem10(),
					new Problem11(),
					new Problem12(),
					new Problem13(),
					new Problem14(),
					new Problem15(),
					new Problem16(),
					new Problem17(),
					new Problem18(),
					new Problem19(),
					new Problem20(),
					new Problem21(),
					new Problem22(),
					new Problem23(),
					new Problem24(),
					new Problem25(),
                    new Problem27(),
					new Problem28(),
					new Problem29(),
					new Problem30(),
                    new Problem31(),
                    new Problem32(),
                    new Problem33(),
					new Problem34(),
					new Problem35(),
					new Problem36(),
					new Problem37(),
			        new Problem38(),
			        new Problem39(),
                    new Problem41(),
					new Problem42(),
			        new Problem43(),
			        new Problem44(),
					new Problem45(),
					new Problem67()
				};

			Stopwatch watch = new Stopwatch();
			watch.Start();

			//new Problem26().Solve();
			new Problem46().Solve();
			//new Problem32().Solve();

			watch.Stop();
			Console.WriteLine("Time: {0}", watch.ElapsedMilliseconds);
			//new Problem48().Solve();

			//Problem 48
			//Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.
			//Answer - 9110846700

			//var query = from x in Enumerable.Range(1, 500)
			//            select (Math.Pow(x, x));

			//var result = new BigInteger(0);
			//foreach (var item in query)
			//{
			//    result += item;
			//}

			//Console.WriteLine(result);
		}
	}
}
