using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class LongestStringChain
    {
		public class stringChain
		{
			public string nextstring;
			public int maxChainLength;

			public stringChain(string nextstring, int maxChainLength)
			{
				this.nextstring = nextstring;
				this.maxChainLength = maxChainLength;
			}
		}

		public static List<string> LongestStringChainSolution(List<string> strings)
		{
			Dictionary<string, stringChain> stringChains = new Dictionary<string, stringChain>();
			foreach (string str in strings)
			{
				stringChains[str] = new stringChain("", 1);
			}

			List<string> sortedstrings = new List<string>(strings);
			sortedstrings.Sort((a, b) => a.Length - b.Length);

			foreach (string str in sortedstrings)
			{
				findLongeststringChain(str, stringChains);
			}

			return buildLongeststringChain(strings, stringChains);
		}

		public static void findLongeststringChain(string str, Dictionary<string, stringChain> stringChains)
		{
			for (int i = 0; i < str.Length; i++)
			{
				string smallerstring = getSmallerstring(str, i);
				if (!stringChains.ContainsKey(smallerstring)) continue;
				tryUpdateLongeststringChain(str, smallerstring, stringChains);
			}
		}

		public static string getSmallerstring(string str, int index)
		{
			return str.Substring(0, index) + str.Substring(index + 1);
		}

		public static void tryUpdateLongeststringChain(string currentstring, string smallerstring, Dictionary<string, stringChain> stringChains)
		{
			int smallerstringChainLength = stringChains[smallerstring].maxChainLength;
			int currentstringChainLength = stringChains[currentstring].maxChainLength;

			if (smallerstringChainLength + 1 > currentstringChainLength)
			{
				stringChains[currentstring].maxChainLength = smallerstringChainLength + 1;
				stringChains[currentstring].nextstring = smallerstring;
			}
		}

		public static List<string> buildLongeststringChain(List<string> strings, Dictionary<string, stringChain> stringChains)
		{
			int maxChainLength = 0;
			string chainStartingstring = "";
			foreach (string str in strings)
			{
				if (stringChains[str].maxChainLength > maxChainLength)
				{
					maxChainLength = stringChains[str].maxChainLength;
					chainStartingstring = str;
				}
			}

			List<string> ourLongeststringChain = new List<string>();
			string currentstring = chainStartingstring;
			while (currentstring != "")
			{
				ourLongeststringChain.Add(currentstring);
				currentstring = stringChains[currentstring].nextstring;
			}

			return ourLongeststringChain.Count == 1 ? new List<string>() : ourLongeststringChain;
		}

	}
}
