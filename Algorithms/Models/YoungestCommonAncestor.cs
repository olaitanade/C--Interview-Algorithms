using System;
namespace Algorithms.Models
{
    public class YoungestCommonAncestor
    {
		public static AncestralTree GetYoungestCommonAncestor(
	AncestralTree topAncestor,
	AncestralTree descendantOne,
	AncestralTree descendantTwo
	)
		{
			int depthOne = getDescendantDepth(descendantOne, topAncestor);
			int depthTwo = getDescendantDepth(descendantTwo, topAncestor);
			if (depthOne > depthTwo)
			{
				return backtrackAncestralTree(descendantOne, descendantTwo, depthOne - depthTwo);
			}
			else
			{
				return backtrackAncestralTree(descendantTwo, descendantOne, depthTwo - depthOne);
			}
		}

		public static int getDescendantDepth(AncestralTree descendant, AncestralTree topAncestor)
		{
			int depth = 0;
			while (descendant != topAncestor)
			{
				depth++;
				descendant = descendant.ancestor;
			}
			return depth;
		}

		public static AncestralTree backtrackAncestralTree(AncestralTree lowerDescendant, AncestralTree higherDescendant, int diff)
		{
			while (diff > 0)
			{
				lowerDescendant = lowerDescendant.ancestor;
				diff--;
			}
			while (lowerDescendant != higherDescendant)
			{
				lowerDescendant = lowerDescendant.ancestor;
				higherDescendant = higherDescendant.ancestor;
			}
			return lowerDescendant;
		}
		public class AncestralTree
		{
			public char name;
			public AncestralTree ancestor;

			public AncestralTree(char name)
			{
				this.name = name;
				this.ancestor = null;
			}

			// This method is for testing only.
			public void AddAsAncestor(AncestralTree[] descendants)
			{
				foreach (AncestralTree descendant in descendants)
				{
					descendant.ancestor = this;
				}
			}
		}
	}
}
