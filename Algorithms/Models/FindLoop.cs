using System;
namespace Algorithms.Models
{
    public class FindLoop
    {
		public static LinkedList FindLoopSolution(LinkedList head)
		{
			LinkedList first = head.next;
			LinkedList second = head.next.next;
			while (first != second)
			{
				first = first.next;
				second = second.next.next;
			}
			first = head;
			while (first != second)
			{
				first = first.next;
				second = second.next;
			}
			return first;
		}

		public class LinkedList
		{
			public int value;
			public LinkedList next = null;

			public LinkedList(int value)
			{
				this.value = value;
			}
		}
	}
}
