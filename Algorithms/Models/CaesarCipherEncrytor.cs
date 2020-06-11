using System;
namespace Algorithms.Models
{
    public class CaesarCipherEncrytor
    {
		public static string CaesarCypherEncryptorSolution1(string str, int key)
		{
			char[] newLetters = new char[str.Length];
			int newKey = key % 26;
			for (int i = 0; i < str.Length; i++)
			{
				newLetters[i] = getNewLetter(str[i], newKey);
			}
			return new string(newLetters);
		}

		public static char getNewLetter(char letter, int key)
		{
			int newLetterCode = letter + key;
			return newLetterCode <=
							122 ? (char)newLetterCode : (char)(96 + newLetterCode % 122);
		}

		public static string CaesarCypherEncryptorSolutin2(string str, int key)
		{
			char[] newLetters = new char[str.Length];
			int newKey = key % 26;
			string alphabet = "abcdefghijklmnopqrstuvwxyz";
			for (int i = 0; i < str.Length; i++)
			{
				newLetters[i] = getNewLetter(str[i], newKey, alphabet);
			}
			return new string(newLetters);
		}

		public static char getNewLetter(char letter, int key, string alphabet)
		{
			int newLetterCode = alphabet.IndexOf(letter) + key;
			return newLetterCode <=
							25 ? alphabet[newLetterCode] : alphabet[-1 + newLetterCode % 25];
		}
	}
}
