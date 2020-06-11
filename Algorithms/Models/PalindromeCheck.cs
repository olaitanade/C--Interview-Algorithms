using System;
using System.Text;

namespace Algorithms.Models
{
    public class PalindromeCheck
    {
		public static bool IsPalindromeSolution1(string str)
		{
			string reversedstring = "";
			for (int i = str.Length - 1; i >= 0; i--)
			{
				reversedstring += str[i];
			}
			return str.Equals(reversedstring);
		}

		public static bool IsPalindromeSolution2(string str)
		{
			StringBuilder reversedstring = new StringBuilder();
			for (int i = str.Length - 1; i >= 0; i--)
			{
				reversedstring.Append(str[i]);
			}
			return str.Equals(reversedstring.ToString());
		}

		public static bool IsPalindromeSolution3(string str)
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

		public static bool IsPalindromeSolution4(string str)
		{
			return IsPalindrome(str, 0);
		}

		public static bool IsPalindrome(string str, int i)
		{
			int j = str.Length - 1 - i;
			return i >= j ? true : str[i] == str[j] && IsPalindrome(str, i + 1);
		}
	}
}
