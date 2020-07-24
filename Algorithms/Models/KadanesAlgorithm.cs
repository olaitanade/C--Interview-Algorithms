using System;
namespace Algorithms.Models
{
    public class KadanesAlgorithm
    {
		public static int KadanesAlgorithmSolution1(int[] array)
		{
			int maxEndingHere = array[0];
			int maxSoFar = array[0];
			for (int i = 1; i < array.Length; i++)
			{
				int num = array[i];
				maxEndingHere = Math.Max(num, maxEndingHere + num);
				maxSoFar = Math.Max(maxSoFar, maxEndingHere);
			}
			return maxSoFar;
		}
	}
}
