using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Day003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //****************************************************************************************************
            //Problem 1 - Most frequent number
            //Requirements
            //[ ] Return the number occurring most often.
            //[ ] Return null for an empty array.
            //[ ] If multiple numbers have the same highest frequency,
            //    return the one that appears FIRST in the original array.
            //[ ] Negative numbers are allowed.
            //[ ] Do not use LINQ.

            //FIXED - It doesnt behave well when all numbers are different and when the first number is neggative
            //It doesn't print a message when the array is null

            //int[] numbers = { 5, 4, 3 };

            //int? mostFrequentNumber = FindMostFrequent(numbers);

            //Console.WriteLine($"Most frequent number: {mostFrequentNumber}");


            //int? FindMostFrequent(int[] numbers)
            //{
            //    int? mostFrequentNumber = null;
            //    int frequency = 0;

            //    Dictionary<int, int> numberOccurrence = new Dictionary<int, int>();

            //    if (numbers != null)
            //    {
            //        //Count ocurrence
            //        for (int i = 0; i < numbers.Length; i++)
            //        {
            //            if (numberOccurrence.ContainsKey(numbers[i]))
            //            {
            //                numberOccurrence[numbers[i]]++;
            //            }
            //            else
            //            {
            //                numberOccurrence[numbers[i]] = 1;
            //            }
            //        }

            //        //Return most frequent
            //        foreach (var kvp in numberOccurrence)
            //        {
            //            if (kvp.Value > frequency)
            //            {
            //                frequency = kvp.Value;
            //                mostFrequentNumber = kvp.Key;
            //            }
            //        }
            //        return mostFrequentNumber;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}


            //****************************************************************************************************
            //Problem 2 - Common values
            //Requirements
            //[ ] Return only values appearing in both arrays.
            //[ ] Do not return duplicates.
            //[ ] Preserve the order in which the values appear in first.
            //[ ] Do not use LINQ.
            //[ ] Do not modify either input array.

            //Nothing is printed if both arrays are empty
            //Nothing is printed if an array is empty
            //Nothing is printed if all are different


            //int[] first = { 8, 3, 7, 3, 2, 8 };
            //int[] second = { 7, 8, 9 };

            //int[] result = FindCommonValues(first, second);
            //foreach (int n in result)
            //{
            //    Console.Write($"{n} ");
            //}

            //int[] FindCommonValues(int[] first, int[] second)
            //{
            //    int[] result = { };
            //    HashSet<int> commonNonRepeted = new HashSet<int>();

            //    //Find and store the common values
            //    for (int i = 0; i < first.Length; i++)
            //    {
            //        for (int j = 0; j < second.Length; j++)
            //        {
            //            if (first[i] == second[j])
            //            {
            //                commonNonRepeted.Add(first[i]);
            //            }
            //        }
            //    }
            //    result = commonNonRepeted.ToArray();
            //    return result;
            //}



        }
    }
}
