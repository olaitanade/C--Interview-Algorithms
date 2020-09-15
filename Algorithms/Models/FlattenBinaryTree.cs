using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class FlattenBinaryTree
    {
		public static BinaryTree FlattenBinaryTreeSolution(BinaryTree root)
		{
			List<BinaryTree> inOrderNodes = getNodesInOrder(root, new List<BinaryTree>());
			for (int i = 0; i < inOrderNodes.Count - 1; i++)
			{
				BinaryTree leftNode = inOrderNodes[i];
				BinaryTree rightNode = inOrderNodes[i + 1];
				leftNode.right = rightNode;
				rightNode.left = leftNode;
			}
			return inOrderNodes[0];
		}

		public static List<BinaryTree> getNodesInOrder(BinaryTree tree, List<BinaryTree> array)
		{
			if (tree != null)
			{
				getNodesInOrder(tree.left, array);
				array.Add(tree);
				getNodesInOrder(tree.right, array);
			}
			return array;
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
