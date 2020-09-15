using System;
namespace Algorithms.Models
{
    public class RightSiblingTree
    {
		public static BinaryTree RightSiblingTreeSolution(BinaryTree root)
		{
			mutate(root, null, false);
			return root;
		}

		public static void mutate(BinaryTree node, BinaryTree parent, bool isLeftChild)
		{
			if (node == null) return;

			var left = node.left;
			var right = node.right;
			mutate(left, node, true);
			if (parent == null)
			{
				node.right = null;
			}
			else if (isLeftChild)
			{
				node.right = parent.right;
			}
			else
			{
				if (parent.right == null)
				{
					node.right = null;
				}
				else
				{
					node.right = parent.right.left;
				}
			}
			mutate(right, node, false);
		}

		// This is the class of the input root. Do not edit it.
		public class BinaryTree
		{
			public int value;
			public BinaryTree left = null;
			public BinaryTree right = null;

			public BinaryTree(int value)
			{
				this.value = value;
			}
		}
	}
}
