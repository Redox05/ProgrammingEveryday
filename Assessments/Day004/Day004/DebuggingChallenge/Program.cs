namespace DebuggingChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 5, 8, 2 };
            //int[] numbers = { -5, -2, -9 };
            //int[] numbers = { 0 };
            //int[] numbers = { -1 };
            int[] numbers = { };

            int? largest = FindLargest(numbers);
            
            if(largest.HasValue){
                Console.WriteLine($"{largest}");
            }
            else{
                Console.WriteLine($"The arreay was empty");
            }

            int? FindLargest(int[] numbers)
            {
                if(numbers == null || numbers.Length==0){
                    return null;
                }
                int largest = int.MinValue;

                foreach (int number in numbers)
                {
                    if (number > largest)
                    {
                        largest = number;
                    }
                }

                return largest;
            }
        }
    }
}
