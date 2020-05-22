using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class NodeDepths
    {
		public static int NodeDepthsSolution1(BinaryTree root)
		{
			int sumOfDepths = 0;
			Stack<Level> stack = new Stack<Level>();
			stack.Push(new Level(root, 0));
			while (stack.Count > 0)
			{
				Level top = stack.Pop();

				BinaryTree node = top.root;
				int depth = top.depth;
				if (node == null) continue;

				sumOfDepths += depth;
				stack.Push(new Level(node.left, depth + 1));
				stack.Push(new Level(node.right, depth + 1));
			}
			return sumOfDepths;
		}

		public static int NodeDepthsSolution2(BinaryTree root)
		{
			return nodeDepthsHelper(root, 0);
		}

		public static int nodeDepthsHelper(BinaryTree root, int depth)
		{
			if (root == null) return 0;
			return depth + nodeDepthsHelper(root.left, depth + 1) + nodeDepthsHelper(root.right, depth + 1);
		}

		public class Level
		{
			public BinaryTree root;
			public int depth;

			public Level(BinaryTree root, int depth)
			{
				this.root = root;
				this.depth = depth;
			}
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
