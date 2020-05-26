using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class ProductSum
    {
		public static int ProductSumSolution1(List<object> array)
		{
			return productSumHelper(array, 1);
		}

		public static int productSumHelper(List<object> array, int multiplier)
		{
			int sum = 0;
			foreach (object el in array)
			{
				if (el is IList<object>)
				{
					sum += productSumHelper((List<object>)el, multiplier + 1);
				}
				else
				{
					sum += (int)el;
				}
			}
			return sum * multiplier;
		}
	}
}
