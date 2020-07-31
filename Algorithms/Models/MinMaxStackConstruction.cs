using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class MinMaxStackConstruction
    {
		List<Dictionary<string, int>> minMaxStack = new List<Dictionary<string, int>>();
		List<int> stack = new List<int>();

		public int Peek()
		{
			return stack[stack.Count - 1];
		}

		public int Pop()
		{
			minMaxStack.RemoveAt(minMaxStack.Count - 1);
			var val = stack[stack.Count - 1];
			stack.RemoveAt(stack.Count - 1);
			return val;
		}

		public void Push(int number)
		{
			Dictionary<string, int> newMinMax = new Dictionary<string, int>();
			newMinMax.Add("min", number);
			newMinMax.Add("max", number);
			if (minMaxStack.Count > 0)
			{
				Dictionary<string, int> lastMinMax = new Dictionary<string, int>(minMaxStack[minMaxStack.Count - 1]);
				newMinMax["min"] = Math.Min(lastMinMax["min"], number);
				newMinMax["max"] = Math.Max(lastMinMax["max"], number);
			}
			minMaxStack.Add(newMinMax);
			stack.Add(number);
		}

		public int GetMin()
		{
			return minMaxStack[minMaxStack.Count - 1]["min"];
		}

		public int GetMax()
		{
			return minMaxStack[minMaxStack.Count - 1]["max"];
		}
	}
}
