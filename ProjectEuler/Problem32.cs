using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
    class Problem32: Solution
    {
        public void Solve()
        {
            int sumOfProducts = 0;
            for (int i = 1000; i < 99999; i++)
            {
                var theList = getProducts(i);
                foreach (var item in theList)
                {
                    if (isPanDigital(item.Item1, item.Item2, i))
                    {
                        sumOfProducts += i;
                        Console.WriteLine("{0} + {1} = {2} is pandigital", item.Item1, item.Item2, i);
                        break;
                    }
                }
            }
            Console.WriteLine("Sum of products: {0}", sumOfProducts);
        }

        private List<Tuple<int, int>> getProducts(int num)
        {
            List<Tuple<int, int>> theList = new List<Tuple<int, int>>();
            int theRoot = (int)Math.Sqrt(num);
            for (int i = 2; i < theRoot; i++)
            {
                if ((num % i) == 0)
                    theList.Add(Tuple.Create(i, num / i));
            }
            return theList;
        }

        private int[] putIntNumsIntoArray(int theInt)
        {
            int[] theArray = new int[numOfDigits(theInt)];

            for (int i = 1, j = 0; i < theInt; i *= 10, j++)
                theArray[j] = (theInt / i) % 10;

            return theArray;
        }

        private int numOfDigits(int theInt)
        {
            int someVal = 10;
            int numDigits = 1;
            while ((theInt / someVal) > 0)
            {
                numDigits++;
                someVal *= 10;
            }
            return numDigits;

        }

        private Boolean isPanDigital(int multiplicand, int multiplier, int product)
        {
            //Determine int from multiplicand, multiplier and product
            /*
            int realVal = multiplicand;
            realVal *= (int)Math.Pow(10, numOfDigits(multiplier));
            realVal += multiplier;
            realVal *= (int) Math.Pow(10, numOfDigits(product));
            realVal += product;
            */
            
            //Concat into string
            String numbers = multiplicand.ToString() + multiplier.ToString() + product.ToString();

            //Exit if resulting value isn't 9 digits
            if (numbers.Length != 9)
                return false;

            //Take result and put into array
            int[] temp = putIntNumsIntoArray(Int32.Parse(numbers));

            //int[] temp = convCharsToInts(numbers.ToCharArray());
            //int[] temp = putIntNumsIntoArray(realVal);

            //Are digits distinct and contain values 1 - 9?
            if (distinctCount(temp) == 9
                    && temp.Sum() == 45)
                return true;
            
            return false;
        }

        private int distinctCount(int[] array)
        {
            int count = (int)array.Length;
            for (int i = 0; i < array.Length - 1; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] == array[j])
                        count--;
            return count;
        }

        private int[] convCharsToInts(char[] array)
        {
            int[] newArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                newArray[i] = Int32.Parse(array[i].ToString());
            return newArray;
        }
    }
}
