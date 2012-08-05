using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem49: Solution
    {
        public void Solve()
        {
            List<int> primes = new List<int>(1000);
            
            //Get list of primes
            for (int i = 1001; i < 9999; i += 2)
                if (CustomMath.isPrime(i))
                    primes.Add(i);

            for (int i = 0; i < primes.Count; i++)
            {
                //If we have a permutation for a given prime add it
                var res = new List<int>() { primes[i] };
                for (int j = i + 1; j < primes.Count; j++)
                    if (isAPermutation(primes[i], primes[j]))
                        res.Add(primes[j]);

                if (res.Count > 2 && differences(res) > -1)
                    printArray(res, differences(res));
            }
        }

        private int differences(List<int> theList)
        {
            for (int i = 0; i < theList.Count - 1; i++)
            {
                List<int> diffs = new List<int>();
                for (int j = i + 1; j < theList.Count; j++)
                    diffs.Add(theList[j] - theList[i]);

                for (int k = 0; k < diffs.Count; k++)
                    for (int j = k + 1; j < diffs.Count; j++)
                        if (diffs[k] * 2 == diffs[j])
                            return k;
            }
            return -1;
        }

        private void printArray(List<int> theList, int index)
        {
            Console.WriteLine("Initial Value: {0}", theList[index]);
            for (int i = index; i < theList.Count; i++)
                Console.WriteLine("{0} - {1} = {2}", theList[i], theList[index], theList[i] - theList[index]);
        }

        private bool isAPermutation(int orig, int comp)
        {
            var x = orig.ToString();
            var y = comp.ToString();

            if (distinctCount(x) != distinctCount(y))
                return false;

            return antiJoin(x, y).Length == 0;
        }

        private string antiJoin (string x, string y)
        {
            string temp = String.Empty;
            for (int i = 0; i < x.Length; i++)
            {
                int j = 0;
                for (; j < y.Length; j++)
                    if (x[i] == y[j])
                        break;
                if (j == 4)
                    temp += x[i];
                
            }
            return temp;
        }

        private int distinctCount (string x)
        {
            int count = x.Length;
            for (int i = 0; i < x.Length - 1; i++)
                for (int j = i + 1; j < x.Length; j++)
                    if (x[i] == x[j])
                        count--;
            return count;
        }
    }
}
