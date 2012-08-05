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
                    new Problem46(),
                    new Problem47(),
			        new Problem48(),
                    new Problem49(),
                    new Problem50(),
                    new Problem52(),
                    new Problem53(),
                    new Problem55(),
                    new Problem56(),
                    new Problem59(),
                    new Problem63(),
					new Problem67(),
                    new Problem79(),
                    new Problem97()
				};

			Stopwatch watch = new Stopwatch();
			watch.Start();

            /* Amortization for loan */
            /*
            for (double n = 2; n < 360; n++)
            {
                double p = 300000;
                double r = 0.0399;
                double t = 1;
                //double n = 5;
                double result = (p * (r / n)) / (1 - Math.Pow((1 + r / n), -n * t));
                double interestPaid = (p * r) / 12;
                for (int i = 1; i < n; i++)
                {
                    interestPaid += ((p - result) * r) / 12;
                    p -= result;
                }
                Console.WriteLine("For {2} payments, you're monthly payment is: {0} and you will the total interest paid is {1}", result, interestPaid, n);
            }
            */
            //new Problem92().Solve();
            new Problem57().Solve();
            //new Problem63().Solve();

			watch.Stop();
			Console.WriteLine("Time: {0}", watch.ElapsedMilliseconds);
            Console.WriteLine();
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
