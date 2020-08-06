using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class LargestRange
    {
		public static int[] LargestRangeSolution1(int[] array)
		{
			int[] bestRange = new int[2];
			int longestLength = 0;
			HashSet<int> nums = new HashSet<int>();
			foreach (int num in array)
			{
				nums.Add(num);
			}
			foreach (int num in array)
			{
				if (!nums.Contains(num))
				{
					continue;
				}
				nums.Remove(num);
				int currentLength = 1;
				int left = num - 1;
				int right = num + 1;
				while (nums.Contains(left))
				{
					nums.Remove(left);
					currentLength++;
					left--;
				}
				while (nums.Contains(right))
				{
					nums.Remove(right);
					currentLength++;
					right++;
				}
				if (currentLength > longestLength)
				{
					longestLength = currentLength;
					bestRange = new int[] { left + 1, right - 1 };
				}
			}
			return bestRange;
		}
	}
}
