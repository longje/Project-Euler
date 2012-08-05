using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem52: Solution
    {
        public void Solve()
        {
            int x = 2;
            int count = 1;
            int i = 125874;
            for (; ; i++)
            {
                while (CustomMath.isAPermutation(i, (i * x++)) && count++ < 6) ;
                if (count == 6)
                    break;
                x = 2;
                count = 1;
            }
            Console.WriteLine("The winner is {0}, {1}, {2}, {3}, {4}, {5}", i, i*2, i*3, i*4, i*5, i*6);
        }


    }
}
