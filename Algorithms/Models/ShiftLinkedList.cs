using System;
namespace Algorithms.Models
{
    public class ShiftLinkedList
    {
		public static LinkedList ShiftLinkedListSolution1(LinkedList head, int k)
		{
			int listLength = 1;
			LinkedList listTail = head;
			while (listTail.next != null)
			{
				listTail = listTail.next;
				listLength++;
			}

			int offset = Math.Abs(k) % listLength;
			if (offset == 0) return head;
			int newTailPosition = k > 0 ? listLength - offset : offset;
			LinkedList newTail = head;
			for (int i = 1; i < newTailPosition; i++)
			{
				newTail = newTail.next;
			}

			LinkedList newHead = newTail.next;
			newTail.next = null;
			listTail.next = head;
			return newHead;
		}

		public class LinkedList
		{
			public int value;
			public LinkedList next;

			public LinkedList(int value)
			{
				this.value = value;
				next = null;
			}
		}
	}
}
