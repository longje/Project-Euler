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
			/*
			new problem3().Solve();
			new Problem4().Solve();
			new Problem5().Solve();
			new Problem6().Solve();
			new Problem7().Solve();
			new Problem8().Solve();
			new Problem9().Solve();
			new Problem10().Solve();
			new Problem11().Solve();
			new Problem12().Solve();
			new Problem13().Solve();
			new Problem14().Solve();
			new Problem15().Solve();
			new Problem16().Solve();
			new Problem17().Solve();
			new Problem18().Solve();
			new Problem19().Solve();
			new Problem20().Solve();
			new Problem21().Solve();
			new Problem22().Solve();
			new Problem23().Solve();
			new Problem24().Solve();
			new Problem25().Solve();
			new Problem28().Solve();
			new Problem29().Solve();
			new Problem30().Solve();
			new Problem34().Solve();
			new Problem35().Solve();
			new Problem36().Solve();
			new Problem42().Solve();
			new Problem67().Solve();
			*/
			Stopwatch watch = new Stopwatch();
			watch.Start();

			//new Problem26().Solve();
			new Problem42().Solve();
			new Problem45().Solve();

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
