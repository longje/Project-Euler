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
<<<<<<< HEAD
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
					new Problem42(),
					new Problem45(),
					new Problem67()
				};

=======
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
>>>>>>> 2adf96cfd37225daa16b6c0fbf78cfa263271b72
			Stopwatch watch = new Stopwatch();
			watch.Start();

			//new Problem26().Solve();
<<<<<<< HEAD
			new Problem38().Solve();
			//new Problem32().Solve();
=======
			new Problem42().Solve();
			new Problem45().Solve();
>>>>>>> 2adf96cfd37225daa16b6c0fbf78cfa263271b72

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
