using System;
namespace Algorithms.Models
{
    public class InsertionSort
    {
		public static int[] InsertionSortSolution1(int[] array)
		{
			if (array.Length == 0)
			{
				return new int[] { };
			}
			for (int i = 1; i < array.Length; i++)
			{
				int j = i;
				while (j > 0 && array[j] < array[j - 1])
				{
					swap(j, j - 1, array);
					j -= 1;
				}
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
