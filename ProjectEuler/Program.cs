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

<<<<<<< HEAD
>>>>>>> 026c19f614b0b3c3fafa634960833e640c2ee0c2
            //new Problem92().Solve();
            new Problem57().Solve();
            //new Problem63().Solve();

			watch.Stop();
			Console.WriteLine("Time: {0}", watch.ElapsedMilliseconds);
            Console.WriteLine();
<<<<<<< HEAD
=======

>>>>>>> 026c19f614b0b3c3fafa634960833e640c2ee0c2
		}
	}
}
