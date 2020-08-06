using System;
namespace Algorithms.Models
{
    public class LongestPalindromicSubstring
    {
		public static string LongestPalindromicSubstringSolution1(string str)
		{
			string longest = "";
			for (int i = 0; i < str.Length; i++)
			{
				for (int j = i; j < str.Length; j++)
				{
					string substring = str.Substring(i, j + 1 - i);
					if (substring.Length > longest.Length && IsPalindrome(substring))
					{
						longest = substring;
					}
				}
			}
			return longest;
		}

		public static bool IsPalindrome(string str)
		{
			int leftIdx = 0;
			int rightIdx = str.Length - 1;
			while (leftIdx < rightIdx)
			{
				if (str[leftIdx] != str[rightIdx])
				{
					return false;
				}
				leftIdx++;
				rightIdx--;
			}
			return true;
		}
	}
}
