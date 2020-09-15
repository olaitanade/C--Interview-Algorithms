using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class AllKindsOfNodeDepths
    {
		public static int AllKindsOfNodeDepthsSolution(BinaryTree root)
		{
			int sumOfAllDepths = 0;
			Stack<BinaryTree> stack = new Stack<BinaryTree>();
			stack.Push(root);
			while (stack.Count > 0)
			{
				BinaryTree node = stack.Pop();
				if (node == null) continue;

				sumOfAllDepths += nodeDepths(node, 0);
				stack.Push(node.left);
				stack.Push(node.right);
			}
			return sumOfAllDepths;
		}

		public static int nodeDepths(BinaryTree node, int depth)
		{
			if (node == null) return 0;
			return depth + nodeDepths(node.left, depth + 1) + nodeDepths(node.right, depth + 1);
		}

		public class BinaryTree
		{
			public int value;
			public BinaryTree left;
			public BinaryTree right;

			public BinaryTree(int value)
			{
				this.value = value;
				left = null;
				right = null;
			}
		}
	}
}
