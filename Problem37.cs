using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem37: Solution
    {
        public void Solve()
        {
            int primeTruncCount = 0;
            int start = 12;
            int sum = 0;
            while (primeTruncCount < 11)
            {
                if (isTruncatable(start++))
                {
                    Console.WriteLine(start - 1);
                    primeTruncCount++;
                    sum += start - 1;
                }
            }
            Console.WriteLine("Sum = {0}", sum);
        }

        private Boolean isTruncatable(int num)
        {
            var result = true;
            var arrayNum = num.ToString();
            for (int i = 0; i < arrayNum.Length; i++)
                if (!CustomMath.isPrime(Convert.ToInt64(arrayNum.Substring(i))))
                    result = false;

            for (int i = arrayNum.Length - 1; i > 0; i--)
                if (!CustomMath.isPrime(Convert.ToInt64(arrayNum.Substring(0, i))))
                    result = false;

            return result;
        }
    }
}
