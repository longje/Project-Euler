using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem33: Solution
    {
        public void Solve()
        {
            var results = new List<Tuple<double, double, double, string, double, string, double>>();
            for (double i = 10.0; i < 99.0; i++)
                for (double j = i + 1.0; j < 100.0; j++)
                    results.Add(matchingNums((int)i, (int)j));

            foreach (var x in results)
                if (x.Item3 == x.Item5 && x.Item1 < 10 && x.Item2 < 10 && ((x.Item7 % 10) != 0))
                    Console.WriteLine("{0} , {1}", x.Item4, x.Item6);
        }

        private Tuple<double, double, double, string, double, string, double> matchingNums(int i, int j)
        {
            var newI = i.ToString().ToCharArray();
            var newJ = j.ToString().ToCharArray();

            string resX = "";
            string resY = "";
            int x = 0;
            if (newI[x] != newJ[x] && newI[x] != newJ[x + 1])
                resX += newI[x];
            if (newI[x+1] != newJ[x] && newI[x+1] != newJ[x + 1])
                resX += newI[x+1];

            if (newJ[x] != newI[x] && newJ[x] != newI[x + 1])
                resY += newJ[x];
            if (newJ[x+1] != newI[x] && newJ[x+1] != newI[x + 1])
                resY += newJ[x+1];

            var temp1 = (String.IsNullOrEmpty(resX)) ? (double) i : Convert.ToDouble(resX);
            var temp2 = (String.IsNullOrEmpty(resY)) ? (double) j : Convert.ToDouble(resY);

            return Tuple.Create<double, double, double, string, double, string, double>(temp1, temp2, temp1 / temp2,
                            String.Format("{0} / {1}", temp1, temp2), Convert.ToDouble(i) / Convert.ToDouble(j), String.Format("{0} / {1}", i, j), i);
       }
    }
}
