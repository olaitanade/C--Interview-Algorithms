using System;
namespace Algorithms.Models
{
    public class MinNumberOfCoinsForChange
    {
		public static int MinNumberOfCoinsForChangeSolution1(int n, int[] denoms)
		{
			int[] numOfCoins = new int[n + 1];
			Array.Fill(numOfCoins, Int32.MaxValue);
			numOfCoins[0] = 0;
			int toCompare = 0;
			foreach (int denom in denoms)
			{
				for (int amount = 0; amount < numOfCoins.Length; amount++)
				{
					if (denom <= amount)
					{
						if (numOfCoins[amount - denom] == Int32.MaxValue)
						{
							toCompare = numOfCoins[amount - denom];
						}
						else
						{
							toCompare = numOfCoins[amount - denom] + 1;
						}
						numOfCoins[amount] = Math.Min(numOfCoins[amount], toCompare);
					}
				}
			}
			return numOfCoins[n] != Int32.MaxValue ? numOfCoins[n] : -1;
		}
	}
}
