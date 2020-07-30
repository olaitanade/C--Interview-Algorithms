using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class Permutations
    {
		public static List<List<int>> GetPermutations(List<int> array)
		{
			List<List<int>> permutations = new List<List<int>>();
			GetPermutations(array, new List<int>(), permutations);
			return permutations;
		}

		public static void GetPermutations(List<int> array, List<int> currentPermutation, List<List<int>> permutations)
		{
			if (array.Count == 0 && currentPermutation.Count > 0)
			{
				permutations.Add(currentPermutation);
			}
			else
			{
				for (int i = 0; i < array.Count; i++)
				{
					List<int> newArray = new List<int>(array);
					newArray.RemoveAt(i);
					List<int> newPermutation = new List<int>(currentPermutation);
					newPermutation.Add(array[i]);
					GetPermutations(newArray, newPermutation, permutations);
				}
			}
		}

	}
}
