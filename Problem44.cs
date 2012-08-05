using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem44: Solution
    {
        List<long> theList = new List<long>(5000);
        public void Solve()
        {
            long result;
            for (int currentCount = 1; ; currentCount++)
            {
                theList.Add(getPentagonalNumber(currentCount));
                result = getPairValue(theList[currentCount-1]);
                if ( result != 0)
                {
                    long otherPent = result;
                    Console.WriteLine("{0} and {1} are a pair with a difference of {2}", theList[currentCount-1], otherPent, theList[currentCount-1] - otherPent);
                    break;
                }
            }
        }

        private bool isDifferencePentagonal(long key)
        {
            int begin = 0;
            int end = theList.Count();
            while (end >= begin)
            {
                int mid = (end + begin) >> 1;

                if (theList[mid] < key)
                    begin = mid + 1;
                else if (theList[mid] > key)
                    end = mid - 1;
                else
                    return true;
            }
            return false;
        }

        private bool isSumPentagonal(long n)
        {
            int i = theList.Count();
            while (n > getPentagonalNumber(i++)) ;
            return n == getPentagonalNumber(i-1);
        }

        private long getPentagonalNumber(int n)
        {
            return n * (3 * n - 1) / 2;
        }

        private bool hasSumDifferenceProperty(long n)
        {
            foreach (var x in theList)
                if (isDifferencePentagonal(n - x) && isSumPentagonal(x + n) )
                    return true;
            return false;
        }

        private long getPairValue(long n)
        {
            foreach (var x in theList)
                if (isDifferencePentagonal(n - x) && isSumPentagonal(x + n)) 
                    return x;
            return 0;
        }
    }
}
