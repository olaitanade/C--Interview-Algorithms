using System;
namespace Algorithms.Models
{
    public class ReverseLinkedList
    {
		public static LinkedList ReverseLinkedListSolution(LinkedList head)
		{
			LinkedList previousNode = null;
			LinkedList currentNode = head;
			while (currentNode != null)
			{
				LinkedList nextNode = currentNode.Next;
				currentNode.Next = previousNode;
				previousNode = currentNode;
				currentNode = nextNode;
			}
			return previousNode;
		}

		public class LinkedList
		{
			public int Value;
			public LinkedList Next = null;

			public LinkedList(int value)
			{
				this.Value = value;
			}
		}
	}
}
