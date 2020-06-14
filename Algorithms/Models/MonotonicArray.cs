using System;
namespace Algorithms.Models
{
    public class MonotonicArray
    {
		public static bool IsMonotonicSolution1(int[] array)
		{
			if (array.Length <= 2) return true;

			var direction = array[1] - array[0];
			for (int i = 2; i < array.Length; i++)
			{
				if (direction == 0)
				{
					direction = array[i] - array[i - 1];
					continue;
				}

				if (breaksDirection(direction, array[i - 1], array[i]))
				{
					return false;
				}
			}
			return true;
		}

		public static bool breaksDirection(int direction, int previous, int current)
		{
			var difference = current - previous;
			if (direction > 0) return difference < 0;
			return difference > 0;
		}

		public static bool IsMonotonicSolution2(int[] array)
		{
			var isNonDecreasing = true;
			var isNonIncreasing = true;
			for (int i = 1; i < array.Length; i++)
			{
				if (array[i] < array[i - 1])
				{
					isNonDecreasing = false;
				}

				if (array[i] > array[i - 1])
				{
					isNonIncreasing = false;
				}
			}

			return isNonDecreasing || isNonIncreasing;
		}
	}
}
