using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class SameBsts
    {
		public static bool SameBstsSolution(List<int> arrayOne, List<int> arrayTwo)
		{
			if (arrayOne.Count != arrayTwo.Count) return false;

			if (arrayOne.Count == 0 && arrayTwo.Count == 0) return true;

			if (arrayOne[0] != arrayTwo[0]) return false;

			List<int> leftOne = getSmaller(arrayOne);
			List<int> leftTwo = getSmaller(arrayTwo);
			List<int> rightOne = getBiggerOrEqual(arrayOne);
			List<int> rightTwo = getBiggerOrEqual(arrayTwo);

			return SameBstsSolution(leftOne, leftTwo) && SameBstsSolution(rightOne, rightTwo);
		}

		public static List<int> getSmaller(List<int> array)
		{
			List<int> smaller = new List<int>();
			for (int i = 1; i < array.Count; i++)
			{
				if (array[i] < array[0]) smaller.Add(array[i]);
			}
			return smaller;
		}

		public static List<int> getBiggerOrEqual(List<int> array)
		{
			List<int> biggerOrEqual = new List<int>();
			for (int i = 1; i < array.Count; i++)
			{
				if (array[i] >= array[0]) biggerOrEqual.Add(array[i]);
			}
			return biggerOrEqual;
		}
	}
}
