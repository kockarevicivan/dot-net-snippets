using System.Collections.Generic;

namespace DotNetSnippets.Algorithms
{
    public class RandomService
    {
        private static void WantedSumLinear()
        {
            int[] numbers = { 5, 2, 4, 11, 39 };
            int wantedSum = 13;

            Dictionary<int, int> previousElements = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int complement = wantedSum - numbers[i];

                if (previousElements.ContainsKey(complement))
                    System.Console.WriteLine(previousElements[complement] + " " + i);
                else
                    previousElements[numbers[i]] = i;
            }
        }

        private static void SortedWantedSum()
        {
            int[] numbers = { 1, 2, 3, 9 };
            int wantedSum = 5;

            for (int i = 0, j = numbers.Length - 1; i < numbers.Length && j >= 0;)
            {
                if (i == j) continue;

                if ((numbers[i] + numbers[j]) > wantedSum)
                    j--;
                else if ((numbers[i] + numbers[j]) < wantedSum)
                    i++;
                else
                {
                    System.Console.WriteLine(i + " " + j);
                    break;
                }
            }
        }

        private static void WantedSumNSquared()
        {
            int[] numbers = { 5, 2, 4, 11, 39 };
            int wantedSum = 41;

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == wantedSum)
                        System.Console.WriteLine(i + " " + j);
                }
            }
        }

        private static void SecondMinimum()
        {
            int[] raw = { 3, 2, 5, 6 };
            int minimum = raw[0];
            int secondMinimum = raw[1];

            foreach (int item in raw)
            {
                if (item < minimum)
                {
                    secondMinimum = minimum;
                    minimum = item;
                }
                else if (item < secondMinimum)
                {
                    secondMinimum = item;
                }
            }

            System.Console.WriteLine("min: " + minimum);
            System.Console.WriteLine(secondMinimum);
        }
    }
}
