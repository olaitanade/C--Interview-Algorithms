using System;
namespace Algorithms.Models
{
    public class QuickSort
    {
		public static int[] QuickSortSolution(int[] array)
		{
			QuickSortSolution(array, 0, array.Length - 1);
			return array;
		}

		public static void QuickSortSolution(int[] array, int startIdx, int endIdx)
		{
			if (startIdx >= endIdx)
			{
				return;
			}
			int pivotIdx = startIdx;
			int leftIdx = startIdx + 1;
			int rightIdx = endIdx;
			while (rightIdx >= leftIdx)
			{
				if (array[leftIdx] > array[pivotIdx] && array[rightIdx] < array[pivotIdx])
				{
					swap(leftIdx, rightIdx, array);
				}
				if (array[leftIdx] <= array[pivotIdx])
				{
					leftIdx += 1;
				}
				if (array[rightIdx] >= array[pivotIdx])
				{
					rightIdx -= 1;
				}
			}
			swap(pivotIdx, rightIdx, array);
			bool leftSubarrayIsSmaller = rightIdx - 1 - startIdx < endIdx - (rightIdx + 1);
			if (leftSubarrayIsSmaller)
			{
				QuickSortSolution(array, startIdx, rightIdx - 1);
				QuickSortSolution(array, rightIdx + 1, endIdx);
			}
			else
			{
				QuickSortSolution(array, rightIdx + 1, endIdx);
				QuickSortSolution(array, startIdx, rightIdx - 1);
			}
		}

		public static void swap(int i, int j, int[] array)
		{
			int temp = array[j];
			array[j] = array[i];
			array[i] = temp;
		}
	}
}
