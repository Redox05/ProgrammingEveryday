namespace Day004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { };

            int? firstDuplicate = FindFirstDuplicate(numbers);

            Console.WriteLine($"First duplicate: {firstDuplicate}");

            int? FindFirstDuplicate(int[] numbers){

                int? result = null;
                HashSet<int> valuesInNumbers = new HashSet<int>();

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (!valuesInNumbers.Contains(numbers[i]))
                    {
                        valuesInNumbers.Add(numbers[i]);
                    }
                    else{
                        result = numbers[i];
                        break;
                    }
                }
                return result;
            }
        }
    }
}
