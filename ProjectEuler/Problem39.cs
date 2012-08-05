using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem39: Solution
    {
        List<RightTSolution> theList = new List<RightTSolution>();

        public void Solve()
        {
            int countC = 0;
            int countB = 0;
            int countA = 0;
            //Find all possible solutions for values of a,b,c
            int limit = 500;
            for (int a = 1; a < limit; a++)
            {
                countA++;
                for (int b = a; b < limit; b++)
                {
                    countB++;
                    for (int c = b; c < limit; c++)
                    {
                        countC++;
                        if ((a * a + b * b) == c * c)
                            theList.Add(new RightTSolution(a, b, c, a + b + c));
                    }
                }
            }

            //What was the highest solution count for each perimeter?
            int bestP = 0;
            int thePerim = 0;
            for (int i = 4; i < 1000; i++)
            {
                int num = theList.Count(x => x.perimeter == i);
                if (bestP < num)
                {
                    bestP = num;
                    thePerim = i;
                }
            }
            Console.WriteLine("Number of executions A: {0}", countA);
            Console.WriteLine("Number of executions B: {0}", countB);
            Console.WriteLine("Number of executions C: {0}", countC);
            Console.WriteLine("Number of executions Total: {0}", countC + countB + countA);
            //Print the solutions for the chosen perimeter
            foreach (var item in theList.Where(x => x.perimeter == thePerim))
                Console.WriteLine("{0}^2 + {1}^2 = {2}^2, P = {3}", item.a, item.b, item.c, item.perimeter);
        }
    }

    struct RightTSolution
    {
        public int a;
        public int b;
        public int c;
        public int perimeter;

        public RightTSolution(int a, int b, int c, int perimeter)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.perimeter = perimeter;
        }
    }
}
