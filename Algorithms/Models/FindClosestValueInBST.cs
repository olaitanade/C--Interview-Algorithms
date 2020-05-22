using System;
namespace Algorithms.Models
{
    public class FindClosestValueInBST
    {
        public class BST
        {
            public int value;
            public BST left;
            public BST right;

            public BST(int value)
            {
                this.value = value;
            }
        }

        public FindClosestValueInBST()
        {
        }

        public static int FindClosestValueInBstSolution1(BST tree, int target)
        {
            return FindClosestValueInBstSolution1(tree, target, Int32.MaxValue);
        }

        public static int FindClosestValueInBstSolution1(BST tree, int target, double closest)
        {
            if (Math.Abs(target - closest) > Math.Abs(target - tree.value))
            {
                closest = tree.value;
            }
            if (target < tree.value && tree.left != null)
            {
                return FindClosestValueInBstSolution1(tree.left, target, closest);
            }
            else if (target > tree.value && tree.right != null)
            {
                return FindClosestValueInBstSolution1(tree.right, target, closest);
            }
            else
            {
                return (int)closest;
            }
        }

        public static int FindClosestValueInBstSolution2(BST tree, int target, double closest)
        {
            BST currentNode = tree;
            while (currentNode != null)
            {
                if (Math.Abs(target - closest) > Math.Abs(target - currentNode.value))
                {
                    closest = currentNode.value;
                }
                if (target < currentNode.value)
                {
                    currentNode = currentNode.left;
                }
                else if (target > currentNode.value)
                {
                    currentNode = currentNode.right;
                }
                else
                {
                    break;
                }
            }
            return (int)closest;
        }


    }
}
