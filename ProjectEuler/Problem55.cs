using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem55: Solution
    {
        public void Solve()
        {
            int i = 1;
            int lychrelNums = 0;
            for (; i < 10000; i++)
            {
                int count = 1;
                bool found = false;
                var x = putIntNumsIntoArray(i);
                var y = reverseArray(x);
                var temp = addTwoArrays(x, y);
                while (count++ < 51)
                {
                    if (areArraysEqual(temp, reverseArray(temp)))
                    {
                        //Console.WriteLine("{0} and {1} is not a Lychrel number with palindrome {2}", arraytoString(x), arraytoString(y), arraytoString(temp));
                        found = true;
                        break;
                    }
                    temp = addTwoArrays(temp, reverseArray(temp));
                }
                if (!found)
                    lychrelNums++;
            }
            Console.WriteLine("Total lychrel numbers: {0}", lychrelNums);
        }

        private string arraytoString(int[] x)
        {
            string y = String.Empty;
            foreach (int item in x)
                y += item;
            return y;
        }

        private bool areArraysEqual(int[] x, int[] y)
        {
            for (int i = 0; i < x.Length; i++)
                if (x[i] != y[i])
                    return false;
            return true;
        }

        private int[] reverseArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = array.Length - 1, j = 0; i > -1; i--, j++)
                newArray[j] = array[i];
            return newArray;
        }

        private int[] addTwoArrays(int[] x, int[] y)
        {
            int[] z = new int[x.Length + 1];
            int carry = 0;
            for (int i = x.Length - 1; i > -1; i--)
            {
                if (x[i] + y[i] + carry > 9)
                {
                    z[i+1] = (x[i] + y[i] + carry) % 10;
                    carry = 1;
                }
                else
                {
                    z[i+1] = x[i] + y[i] + carry;
                    carry = 0;
                }
            }

            z[0] = carry;
            if (carry == 0)
                z = removeFirst(z);

            return z;
        }

        private int[] removeFirst(int[] x)
        {
            int[] newArray = new int[x.Length - 1];
            for (int i = 1; i < x.Length; i++)
                newArray[i-1] = x[i];
            return newArray;
        }

        private int sizeOfNum(int theInt)
        {
            if (theInt < 10)
                return 1;
            else if (theInt < 100)
                return 2;
            else if (theInt < 1000)
                return 3;
            else if (theInt < 10000)
                return 4;
            return 4;
        }

        private int[] putIntNumsIntoArray(int theInt)
        {
            int[] theArray = new int[sizeOfNum(theInt)];

            for (int i = 1, j = 0; i < theInt; i *= 10, j++)
                theArray[theArray.Length - 1 - j] = (theInt / i) % 10;

            return theArray;
        }
    }
}
