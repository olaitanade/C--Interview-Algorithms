using System;
namespace Algorithms.Models
{
    public class BubbleSort
    {
		public static int[] BubbleSortSolution1(int[] array)
		{
			if (array.Length == 0)
			{
				return new int[] { };
			}
			bool isSorted = false;
			int counter = 0;
			while (!isSorted)
			{
				isSorted = true;
				for (int i = 0; i < array.Length - 1 - counter; i++)
				{
					if (array[i] > array[i + 1])
					{
						swap(i, i + 1, array);
						isSorted = false;
					}
				}
				counter++;
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
