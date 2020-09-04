using System;
namespace Algorithms.Models
{
    public class MergeLinkedLists
    {
		public class LinkedList
		{
			public int value;
			public LinkedList next;

			public LinkedList(int value)
			{
				this.value = value;
				this.next = null;
			}
		}

		public static LinkedList mergeLinkedLists(LinkedList headOne, LinkedList headTwo)
		{
			LinkedList p1 = headOne;
			LinkedList p1Prev = null;
			LinkedList p2 = headTwo;
			while (p1 != null && p2 != null)
			{
				if (p1.value < p2.value)
				{
					p1Prev = p1;
					p1 = p1.next;
				}
				else
				{
					if (p1Prev != null)
						p1Prev.next = p2;
					p1Prev = p2;
					p2 = p2.next;
					p1Prev.next = p1;
				}
			}
			if (p1 == null)
				p1Prev.next = p2;
			return headOne.value < headTwo.value ? headOne : headTwo;
		}

	}
}
