using System;
namespace Algorithms.Models
{
    public class LinkedListConstruction
    {
		public class DoublyLinkedList
		{
			public Node Head;
			public Node Tail;

			// O(1) time | O(1) space
			public void SetHead(Node node)
			{
				if (Head == null)
				{
					Head = node;
					Tail = node;
					return;
				}
				InsertBefore(Head, node);
			}

			// O(1) time | O(1) space
			public void SetTail(Node node)
			{
				if (Tail == null)
				{
					SetHead(node);
					return;
				}
				InsertAfter(Tail, node);
			}

			public void InsertBefore(Node node, Node nodeToInsert)
			{
				if (nodeToInsert == Head && nodeToInsert == Tail) return;
				Remove(nodeToInsert);
				nodeToInsert.Prev = node.Prev;
				nodeToInsert.Next = node;
				if (node.Prev == null)
				{
					Head = nodeToInsert;
				}
				else
				{
					node.Prev.Next = nodeToInsert;
				}
				node.Prev = nodeToInsert;
			}

			public void InsertAfter(Node node, Node nodeToInsert)
			{
				if (nodeToInsert == Head && nodeToInsert == Tail) return;
				Remove(nodeToInsert);
				nodeToInsert.Prev = node;
				nodeToInsert.Next = node.Next;
				if (node.Next == null)
				{
					Tail = nodeToInsert;
				}
				else
				{
					node.Next.Prev = nodeToInsert;
				}
				node.Next = nodeToInsert;
			}

			public void InsertAtPosition(int position, Node nodeToInsert)
			{
				if (position == 1)
				{
					SetHead(nodeToInsert);
					return;
				}
				Node node = Head;
				int currentPosition = 1;
				while (node != null && currentPosition++ != position) node = node.Next;
				if (node != null)
				{
					InsertBefore(node, nodeToInsert);
				}
				else
				{
					SetTail(nodeToInsert);
				}
			}

			public void RemoveNodesWithValue(int value)
			{
				Node node = Head;
				while (node != null)
				{
					Node nodeToRemove = node;
					node = node.Next;
					if (nodeToRemove.Value == value) Remove(nodeToRemove);
				}
			}

			public void Remove(Node node)
			{
				if (node == Head) Head = Head.Next;
				if (node == Tail) Tail = Tail.Prev;
				RemoveNodeBindings(node);
			}

			public bool ContainsNodeWithValue(int value)
			{
				Node node = Head;
				while (node != null && node.Value != value) node = node.Next;
				return node != null;
			}

			public void RemoveNodeBindings(Node node)
			{
				if (node.Prev != null) node.Prev.Next = node.Next;
				if (node.Next != null) node.Next.Prev = node.Prev;
				node.Prev = null;
				node.Next = null;
			}
		}

		// Do not edit the class below.
		public class Node
		{
			public int Value;
			public Node Prev;
			public Node Next;

			public Node(int value)
			{
				this.Value = value;
			}
		}
	}
}
