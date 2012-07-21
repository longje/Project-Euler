using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler
{
	public static class ExtensionMethods
	{
		public static String reverseString(this String value)
		{
			String newValue = "";

			foreach (var x in value.ToCharArray().Reverse())
			{
				newValue += x;
			}

			return newValue;
		}

		public static int productOfRange<T> (this IEnumerable<T> source)
		{
			int myProduct = 1;
			foreach (var x in source)
			{
				myProduct *= Int32.Parse(x.ToString());
			}
			return myProduct;
		}
	}
}
