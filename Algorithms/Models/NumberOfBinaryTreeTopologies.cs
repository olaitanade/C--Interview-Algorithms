using System;
namespace Algorithms.Models
{
    public class NumberOfBinaryTreeTopologies
    {
		public static int NumberOfBinaryTreeTopologiesSolution(int n)
		{
			if (n == 0)
			{
				return 1;
			}
			int numberOfTrees = 0;
			for (int leftTreeSize = 0; leftTreeSize < n; leftTreeSize++)
			{
				int rightTreeSize = n - 1 - leftTreeSize;
				int numberOfLeftTrees = NumberOfBinaryTreeTopologiesSolution(leftTreeSize);
				int numberOfRightTrees = NumberOfBinaryTreeTopologiesSolution(rightTreeSize);
				numberOfTrees += numberOfLeftTrees * numberOfRightTrees;
			}
			return numberOfTrees;
		}
	}
}
