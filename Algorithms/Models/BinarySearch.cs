using System;
namespace Algorithms.Models
{
    public class BinarySearch
    {
		public static int BinarySearchSolution1(int[] array, int target)
		{
			return BinarySearchSolution1(array, target, 0, array.Length - 1);
		}

		public static int BinarySearchSolution1(int[] array, int target, int left, int right)
		{
			if (left > right)
			{
				return -1;
			}
			int middle = (left + right) / 2;
			int potentialMatch = array[middle];
			if (target == potentialMatch)
			{
				return middle;
			}
			else if (target < potentialMatch)
			{
				return BinarySearchSolution1(array, target, left, middle - 1);
			}
			else
			{
				return BinarySearchSolution1(array, target, middle + 1, right);
			}
		}

		public static int BinarySearchSolution2(int[] array, int target)
		{
			return BinarySearchSolution2(array, target, 0, array.Length - 1);
		}

		public static int BinarySearchSolution2(int[] array, int target, int left, int right)
		{
			while (left <= right)
			{
				int middle = (left + right) / 2;
				int potentialMatch = array[middle];
				if (target == potentialMatch)
				{
					return middle;
				}
				else if (target < potentialMatch)
				{
					right = middle - 1;
				}
				else
				{
					left = middle + 1;
				}
			}
			return -1;
		}


	}
}
