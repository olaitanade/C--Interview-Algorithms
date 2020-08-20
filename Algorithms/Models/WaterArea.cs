using System;
namespace Algorithms.Models
{
    public class WaterArea
    {
		public static int WaterAreaSolution1(int[] heights)
		{
			int[] maxes = new int[heights.Length];
			int leftMax = 0;
			for (int i = 0; i < heights.Length; i++)
			{
				int height = heights[i];
				maxes[i] = leftMax;
				leftMax = Math.Max(leftMax, height);
			}
			int rightMax = 0;
			for (int i = heights.Length - 1; i >= 0; i--)
			{
				int height = heights[i];
				int minHeight = Math.Min(rightMax, maxes[i]);
				if (height < minHeight)
				{
					maxes[i] = minHeight - height;
				}
				else
				{
					maxes[i] = 0;
				}
				rightMax = Math.Max(rightMax, height);
			}
			int total = 0;
			for (int i = 0; i < heights.Length; i++)
			{
				total += maxes[i];
			}
			return total;
		}
	}
}
