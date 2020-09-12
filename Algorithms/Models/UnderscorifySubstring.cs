using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class UnderscorifySubstring
    {
		public static string UnderscorifySubstringSolution(string str, string substring)
		{
			List<int[]> locations = collapse(getLocations(str, substring));
			return underscorify(str, locations);
		}

		public static List<int[]> getLocations(string str, string substring)
		{
			List<int[]> locations = new List<int[]>();
			int startIdx = 0;
			while (startIdx < str.Length)
			{
				int nextIdx = str.IndexOf(substring, startIdx);
				if (nextIdx != -1)
				{
					locations.Add(new int[] { nextIdx, nextIdx + substring.Length });
					startIdx = nextIdx + 1;
				}
				else
				{
					break;
				}
			}
			return locations;
		}

		public static List<int[]> collapse(List<int[]> locations)
		{
			if (locations.Count == 0)
			{
				return locations;
			}
			List<int[]> newLocations = new List<int[]>();
			newLocations.Add(locations[0]);
			int[] previous = newLocations[0];
			for (int i = 1; i < locations.Count; i++)
			{
				int[] current = locations[i];
				if (current[0] <= previous[1])
				{
					previous[1] = current[1];
				}
				else
				{
					newLocations.Add(current);
					previous = current;
				}
			}
			return newLocations;
		}

		public static string underscorify(string str, List<int[]> locations)
		{
			int locationsIdx = 0;
			int stringIdx = 0;
			bool inBetweenUnderscores = false;
			List<string> finalChars = new List<string>();
			int i = 0;
			while (stringIdx < str.Length && locationsIdx < locations.Count)
			{
				if (stringIdx == locations[locationsIdx][i])
				{
					finalChars.Add("_");
					inBetweenUnderscores = !inBetweenUnderscores;
					if (!inBetweenUnderscores)
					{
						locationsIdx++;
					}
					i = i == 1 ? 0 : 1;
				}
				finalChars.Add(str[stringIdx].ToString());
				stringIdx += 1;
			}
			if (locationsIdx < locations.Count)
			{
				finalChars.Add("_");
			}
			else if (stringIdx < str.Length)
			{
				finalChars.Add(str.Substring(stringIdx));
			}
			return String.Join("", finalChars);
		}

	}
}
