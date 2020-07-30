using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class Powerset
    {
		public static List<List<int>> PowersetSolution(List<int> array)
		{
			return PowersetSolution(array, array.Count - 1);
		}

		public static List<List<int>> PowersetSolution(List<int> array, int idx)
		{
			if (idx < 0)
			{
				List<List<int>> emptySet = new List<List<int>>();
				emptySet.Add(new List<int>());
				return emptySet;
			}
			int ele = array[idx];
			List<List<int>> subsets = PowersetSolution(array, idx - 1);
			int length = subsets.Count;
			for (int i = 0; i < length; i++)
			{
				List<int> currentSubset = new List<int>(subsets[i]);
				currentSubset.Add(ele);
				subsets.Add(currentSubset);
			}
			return subsets;
		}
	}
}
