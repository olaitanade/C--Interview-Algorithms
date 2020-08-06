using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class SuffixTrieConstruction
    {
		// Do not edit the class below except for the
		// PopulateSuffixTrieFrom and Contains methods.
		// Feel free to add new properties and methods
		// to the class.
		public class TrieNode
		{
			public Dictionary<char, TrieNode> Children = new Dictionary<char, TrieNode>();
		}

		public class SuffixTrie
		{
			public TrieNode root = new TrieNode();
			public char endSymbol = '*';

			public SuffixTrie(string str)
			{
				PopulateSuffixTrieFrom(str);
			}

			public void PopulateSuffixTrieFrom(string str)
			{
				for (int i = 0; i < str.Length; i++)
				{
					insertSubstringStartingAt(i, str);
				}
			}

			public void insertSubstringStartingAt(int i, string str)
			{
				TrieNode node = root;
				for (int j = i; j < str.Length; j++)
				{
					char letter = str[j];
					if (!node.Children.ContainsKey(letter))
					{
						TrieNode newNode = new TrieNode();
						node.Children.Add(letter, newNode);
					}
					node = node.Children[letter];
				}
				node.Children[endSymbol] = null;
			}

			public bool Contains(string str)
			{
				TrieNode node = root;
				for (int i = 0; i < str.Length; i++)
				{
					char letter = str[i];
					if (!node.Children.ContainsKey(letter))
					{
						return false;
					}
					node = node.Children[letter];
				}
				return node.Children.ContainsKey(endSymbol);
			}
		}
	}
}
