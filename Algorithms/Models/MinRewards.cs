using System;
using System.Linq;

namespace Algorithms.Models
{
    public class MinRewards
    {
		public static int MinRewardsSolution1(int[] scores)
		{
			int[] rewards = new int[scores.Length];
			Array.Fill(rewards, 1);
			for (int i = 1; i < scores.Length; i++)
			{
				int j = i - 1;
				if (scores[i] > scores[j])
				{
					rewards[i] = rewards[j] + 1;
				}
				else
				{
					while (j >= 0 && scores[j] > scores[j + 1])
					{
						rewards[j] = Math.Max(rewards[j], rewards[j + 1] + 1);
						j--;
					}
				}
			}
			return rewards.Sum();
		}
	}
}
