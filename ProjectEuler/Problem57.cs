using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace ProjectEuler
{
    class Problem57: Solution
    {
        int numBeatsDenom = 0;
        const int limit = 1000;

        List<Tuple<BigInteger, BigInteger>> runningVals = new List<Tuple<BigInteger, BigInteger>>();

        public void Solve()
        {
            var temp = add(recursiveNumDenom(Tuple.Create<BigInteger, BigInteger>(0, 0), 0, limit), 1);

            foreach (var x in runningVals)
            {
                var temp1 = add(x, 1);
                if (temp1.Item1.ToString().Length > temp1.Item2.ToString().Length)
                    numBeatsDenom++;
            }
            Console.WriteLine("Total number of numerators that are one digit greater than denominator: {0}", numBeatsDenom);
        }

        private Tuple<BigInteger, BigInteger> recursiveNumDenom(Tuple<BigInteger, BigInteger> values, int count, int max)
        {
            count++;

            if (count >= max)
            {
                var temp = Tuple.Create<BigInteger, BigInteger>(1, 2);
                return temp;
            }

            if (count < max)
            {
                var temp = flip(add(recursiveNumDenom(values, count, max), 2));
                runningVals.Add(temp);
                return temp;
            }

            return Tuple.Create<BigInteger, BigInteger>(0, 0);
        }

        private Tuple<BigInteger, BigInteger> add(Tuple<BigInteger, BigInteger> values, int addVal)
        {
            return Tuple.Create<BigInteger, BigInteger>(addVal * values.Item2 + values.Item1, values.Item2);
        }

        private Tuple<BigInteger, BigInteger> flip (Tuple<BigInteger, BigInteger> values)
        {
            return Tuple.Create<BigInteger, BigInteger>(values.Item2, values.Item1);
        }
    }
}
