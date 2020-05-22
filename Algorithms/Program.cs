using System;
using Algorithms.Models;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] result = null;
            Console.WriteLine("AlgoExpert 100 algorithm questions!");
            result= SumOfTwoNumbers.TwoNumberSumSolution1(new int[] {3, 5, -4, 8, 11, 1, -1, 6},10);

            Console.WriteLine("Result");
            Console.WriteLine(result.Length);


        }
    }
}
