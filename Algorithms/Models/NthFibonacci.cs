using System;
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
	}
}
