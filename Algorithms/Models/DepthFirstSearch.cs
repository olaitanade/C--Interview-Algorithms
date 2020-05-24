using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class DepthFirstSearch
    {
		public class Node
		{
			public string name;
			public List<Node> children = new List<Node>();

			public Node(string name)
			{
				this.name = name;
			}

			//O(v+e) time | O(v) space
			public List<string> DepthFirstSearch(List<string> array)
			{
				array.Add(this.name);
				for (int i = 0; i < children.Count; i++)
				{
					children[i].DepthFirstSearch(array);
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
