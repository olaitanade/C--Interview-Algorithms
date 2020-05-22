using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class ValidateSubsequence
    {
        public ValidateSubsequence()
        {
        }

		public static bool IsValidSubsequenceSolution1(List<int> array, List<int> sequence)
		{
			// Write your code here.
			int arrIdx = 0;
			int seqIdx = 0;
			while (arrIdx < array.Count && seqIdx < sequence.Count)
			{
				if (array[arrIdx] == sequence[seqIdx])
				{
					seqIdx++;
				}
				arrIdx++;
			}
			return seqIdx == sequence.Count;
		}

		public static bool IsValidSubsequenceSolution2(List<int> array, List<int> sequence)
		{
			int seqIdx = 0;
			foreach (var val in array)
			{
				if (seqIdx == sequence.Count)
				{
					break;
				}
				if (sequence[seqIdx] == val)
				{
					seqIdx++;
				}
			}
			return seqIdx == sequence.Count;
		}


	}
}
