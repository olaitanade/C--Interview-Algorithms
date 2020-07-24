using System;
namespace Algorithms.Models
{
    public class SingleCycleCheck
    {
		public static bool HasSingleCycle(int[] array)
		{
			int numElementsVisited = 0;
			int currentIdx = 0;
			while (numElementsVisited < array.Length)
			{
				if (numElementsVisited > 0 && currentIdx == 0) return false;
				numElementsVisited++;
				currentIdx = getNextIdx(currentIdx, array);
			}
			return currentIdx == 0;
		}

		public static int getNextIdx(int currentIdx, int[] array)
		{
			int jump = array[currentIdx];
			int nextIdx = (currentIdx + jump) % array.Length;
			return nextIdx >= 0 ? nextIdx : nextIdx + array.Length;
		}
	}
}
