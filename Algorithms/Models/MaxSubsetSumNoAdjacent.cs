using System;
namespace Algorithms.Models
{
    public class MaxSubsetSumNoAdjacent
    {
		public static int MaxSubsetSumNoAdjacentSolution1(int[] array)
		{
			if (array.Length == 0)
			{
				return 0;
			}
			else if (array.Length == 1)
			{
				return array[0];
			}
			int[] maxSums = (int[])array.Clone();
			maxSums[1] = Math.Max(array[0], array[1]);
			for (int i = 2; i < array.Length; i++)
			{
				maxSums[i] = Math.Max(maxSums[i - 1], maxSums[i - 2] + array[i]);
			}
			return maxSums[array.Length - 1];
		}
	}
}
