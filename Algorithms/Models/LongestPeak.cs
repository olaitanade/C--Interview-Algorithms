using System;
namespace Algorithms.Models
{
    public class LongestPeak
    {
		public static int LongestPeakSolution1(int[] array)
		{
			int longestPeakLength = 0;
			int i = 1;
			while (i < array.Length - 1)
			{
				bool isPeak = array[i - 1] < array[i] && array[i] > array[i + 1];
				if (!isPeak)
				{
					i += 1;
					continue;
				}

				int leftIdx = i - 2;
				while (leftIdx >= 0 && array[leftIdx] < array[leftIdx + 1])
				{
					leftIdx -= 1;
				}

				int rightIdx = i + 2;
				while (rightIdx < array.Length && array[rightIdx] < array[rightIdx - 1])
				{
					rightIdx += 1;
				}
				int currentPeakLength = rightIdx - leftIdx - 1;
				if (currentPeakLength > longestPeakLength)
				{
					longestPeakLength = currentPeakLength;
				}
				i = rightIdx;
			}
			return longestPeakLength;
		}
	}
}
