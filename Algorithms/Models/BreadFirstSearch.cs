using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class BreadFirstSearch
    {
		public class Node
		{
			public string name;
			public List<Node> children = new List<Node>();

			public Node(string name)
			{
				this.name = name;
			}

			public List<string> BreadthFirstSearch(List<string> array)
			{
				Queue<Node> queue = new Queue<Node>();
				queue.Enqueue(this);
				while (queue.Count > 0)
				{
					Node current = queue.Dequeue();
					array.Add(current.name);
					current.children.ForEach(o => queue.Enqueue(o));
				}
				return array;
			}

			public Node AddChild(string name)
			{
				Node child = new Node(name);
				children.Add(child);
				return this;
			}
		}
	}
}
