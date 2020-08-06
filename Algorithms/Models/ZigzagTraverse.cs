using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class ZigzagTraverse
    {
		public static List<int> ZigzagTraverseSolution1(List<List<int>> array)
		{
			int height = array.Count - 1;
			int width = array[0].Count - 1;
			List<int> result = new List<int>();
			int row = 0;
			int col = 0;
			bool goingDown = true;
			while (!isOutOfBounds(row, col, height, width))
			{
				result.Add(array[row][col]);
				if (goingDown)
				{
					if (col == 0 || row == height)
					{
						goingDown = false;
						if (row == height)
						{
							col++;
						}
						else
						{
							row++;
						}
					}
					else
					{
						row++;
						col--;
					}
				}
				else
				{
					if (row == 0 || col == width)
					{
						goingDown = true;
						if (col == width)
						{
							row++;
						}
						else
						{
							col++;
						}
					}
					else
					{
						row--;
						col++;
					}
				}
			}
			return result;
		}

		public static bool isOutOfBounds(int row, int col, int height, int width)
		{
			return row < 0 || row > height || col < 0 || col > width;
		}

	}
}
