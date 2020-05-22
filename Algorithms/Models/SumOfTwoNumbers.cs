using System;
using System.Collections.Generic;

namespace Algorithms.Models
{
    public class SumOfTwoNumbers
    {
        public SumOfTwoNumbers()
        {
        }

        public static int[] TwoNumberSumSolution1(int[] array, int targetSum)
        {
            for (int i = 0; i < array.Length-1; i++)
            {
                int firstNum = array[i];
                for (int j = i+1; j < array.Length; j++)
                {
                    int secondNum = j;
                    if (firstNum + secondNum == targetSum)
                    {
                        return new int[] { firstNum, secondNum };
                    }
                }
            }

            return new int[0];
        }

        public static int[] TwoNumberSumSolutuion2(int[] array, int targetSum)
        {
            HashSet<int> nums = new HashSet<int>();
            foreach (int num in array)
            {
                int potentialMatch = targetSum - num;
                if (nums.Contains(potentialMatch))
                {
                    return new int[] { potentialMatch, num };
                }
                else
                {
                    nums.Add(num);
                }
            }
            return new int[0];
        }

        public static int[] TwoNumberSumSolutuion3(int[] array, int targetSum)
        {
            Array.Sort(array);
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int currentSum = array[left] + array[right];
                if (currentSum == targetSum)
                {
                    return new int[] { array[left], array[right] };
                }
                else if (currentSum < targetSum)
                {
                    left++;
                }
                else if (currentSum > targetSum)
                {
                    right--;
                }
            }

            return new int[0];
        }
    }
}
