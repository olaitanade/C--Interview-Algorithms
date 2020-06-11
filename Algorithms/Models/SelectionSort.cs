using System;
namespace Algorithms.Models
{
    public class SelectionSort
    {
		public static int[] SelectionSortSolution1(int[] array)
		{
			if (array.Length == 0)
			{
				return new int[] { };
			}
			int startIdx = 0;
			while (startIdx < array.Length - 1)
			{
				int smallestIdx = startIdx;
				for (int i = startIdx + 1; i < array.Length; i++)
				{
					if (array[smallestIdx] > array[i])
					{
						smallestIdx = i;
					}
				}
				swap(startIdx, smallestIdx, array);
				startIdx++;
			}
			return array;
		}

		public static void swap(int i, int j, int[] array)
		{
			int temp = array[j];
			array[j] = array[i];
			array[i] = temp;
		}
	}
}
