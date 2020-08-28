using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class NumbersInPi
    {
		public static int NumbersInPiSolution1(string pi, string[] numbers)
		{
			HashSet<string> numbersTable = new HashSet<string>();
			foreach (string number in numbers)
			{
				numbersTable.Add(number);
			}
			Dictionary<int, int> cache = new Dictionary<int, int>();
			int minSpaces = getMinSpaces(pi, numbersTable, cache, 0);
			return minSpaces == Int32.MaxValue ? -1 : minSpaces;
		}

		public static int getMinSpaces(string pi, HashSet<string> numbersTable, Dictionary<int, int> cache, int idx)
		{
			if (idx == pi.Length) return -1;
			if (cache.ContainsKey(idx)) return cache[idx];
			int minSpaces = Int32.MaxValue;
			for (int i = idx; i < pi.Length; i++)
			{
				string prefix = pi.Substring(idx, i + 1 - idx);
				if (numbersTable.Contains(prefix))
				{
					int minSpacesInSuffix = getMinSpaces(pi, numbersTable, cache, i + 1);
					// Handle int overflow.
					if (minSpacesInSuffix == Int32.MaxValue)
					{
						minSpaces = Math.Min(minSpaces, minSpacesInSuffix);
					}
					else
					{
						minSpaces = Math.Min(minSpaces, minSpacesInSuffix + 1);
					}
				}
			}
			cache[idx] = minSpaces;
			return cache[idx];
		}

	}
}
