using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class MaxPathSumInBinaryTree
    {
		public static int MaxPathSum(BinaryTree tree)
		{
			List<int> maxSumArray = findMaxSum(tree);
			return maxSumArray[1];
		}

		public static List<int> findMaxSum(BinaryTree tree)
		{
			if (tree == null)
			{
				return new List<int>(){
				0, Int32.MinValue
			};
			}
			List<int> leftMaxSumArray = findMaxSum(tree.left);
			int leftMaxSumAsBranch = leftMaxSumArray[0];
			int leftMaxPathSum = leftMaxSumArray[1];

			List<int> rightMaxSumArray = findMaxSum(tree.right);
			int rightMaxSumAsBranch = rightMaxSumArray[0];
			int rightMaxPathSum = rightMaxSumArray[1];

			int maxChildSumAsBranch = Math.Max(leftMaxSumAsBranch, rightMaxSumAsBranch);
			int maxSumAsBranch = Math.Max(maxChildSumAsBranch + tree.value, tree.value);
			int maxSumAsRootNode = Math.Max(
				leftMaxSumAsBranch + tree.value + rightMaxSumAsBranch,
				maxSumAsBranch
			);
			int maxPathSum = Math.Max(leftMaxPathSum, Math.Max(rightMaxPathSum,
																												maxSumAsRootNode));

			return new List<int>() { maxSumAsBranch, maxPathSum };
		}

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}
	}
}
