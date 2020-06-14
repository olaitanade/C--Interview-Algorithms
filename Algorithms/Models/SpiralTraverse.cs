using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class SpiralTraverse
    {
		public static List<int> SpiralTraverseSolution1(int[,] array)
		{
			if (array.GetLength(0) == 0) return new List<int>();

			var result = new List<int>();
			var startRow = 0;
			var endRow = array.GetLength(0) - 1;
			var startCol = 0;
			var endCol = array.GetLength(1) - 1;

			while (startRow <= endRow && startCol <= endCol)
			{
				for (int col = startCol; col <= endCol; col++)
				{
					result.Add(array[startRow, col]);
				}

				for (int row = startRow + 1; row <= endRow; row++)
				{
					result.Add(array[row, endCol]);
				}

				for (int col = endCol - 1; col >= startCol; col--)
				{
					if (startRow == endRow) break;
					result.Add(array[endRow, col]);
				}

				for (int row = endRow - 1; row > startRow; row--)
				{
					if (startCol == endCol) break;
					result.Add(array[row, startCol]);
				}

				startRow++;
				endRow--;
				startCol++;
				endCol--;
			}
			return result;
		}

		public static List<int> SpiralTraverseSolution2(int[,] array)
		{
			if (array.Length == 0) return new List<int>();

			var result = new List<int>();
			spiralFill(array, 0, array.GetLength(0) - 1, 0, array.GetLength(1) - 1, result);
			return result;
		}

		public static void spiralFill(
			int[,] array,
			int startRow,
			int endRow,
			int startCol,
			int endCol,
			List<int> result)
		{
			if (startRow > endRow || startCol > endCol)
			{
				return;
			}

			for (int col = startCol; col <= endCol; col++)
			{
				result.Add(array[startRow, col]);
			}

			for (int row = startRow + 1; row <= endRow; row++)
			{
				result.Add(array[row, endCol]);
			}

			for (int col = endCol - 1; col >= startCol; col--)
			{
				if (startRow == endRow) break;
				result.Add(array[endRow, col]);
			}

			for (int row = endRow - 1; row >= startRow + 1; row--)
			{
				if (startCol == endCol) break;
				result.Add(array[row, startCol]);
			}
			spiralFill(array, startRow + 1, endRow - 1, startCol + 1, endCol - 1, result);
		}
	}
}
