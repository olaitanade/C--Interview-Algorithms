using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class RightSmallerThan
    {
		public static List<int> RightSmallerThanSolution(List<int> array)
		{
			List<int> rightSmallerCounts = new List<int>();
			for (int i = 0; i < array.Count; i++)
			{
				int rightSmallerCount = 0;
				for (int j = i + 1; j < array.Count; j++)
				{
					if (array[j] < array[i])
					{
						rightSmallerCount++;
					}
				}
				rightSmallerCounts.Add(rightSmallerCount);
			}
			return rightSmallerCounts;
		}

	}
}
