using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class NthFibonacci
    {
		public static int GetNthFibSolution1(int n)
		{
			if (n == 2)
			{
				return 1;
			}
			else if (n == 1)
			{
				return 0;
			}
			else
			{
				return GetNthFibSolution1(n - 1) + GetNthFibSolution1(n - 2);
			}
		}

		public static int GetNthFibSolution2(int n)
		{
			Dictionary<int, int> memorize = new Dictionary<int, int>();
			memorize.Add(1, 0);
			memorize.Add(2, 1);
			return GetNthFibSolution2(n, memorize);
		}

		public static int GetNthFibSolution2(int n, Dictionary<int, int> memorize)
		{
			if (memorize.ContainsKey(n))
			{
				return memorize[n];
			}
			else
			{
				memorize.Add(n, GetNthFibSolution2(n - 1, memorize) + GetNthFibSolution2(n - 2, memorize));
				return memorize[n];
			}
		}

	}
}
