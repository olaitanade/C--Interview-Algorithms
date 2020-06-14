using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class MoveElementToEnd
    {
		public static List<int> MoveElementToEndSolution1(List<int> array, int toMove)
		{
			int i = 0;
			int j = array.Count - 1;
			while (i < j)
			{
				while (i < j && array[j] == toMove) j--;
				if (array[i] == toMove) swap(i, j, array);
				i++;
			}
			return array;
		}

		public static void swap(int i, int j, List<int> array)
		{
			int temp = array[j];
			array[j] = array[i];
			array[i] = temp;
		}
	}
}
