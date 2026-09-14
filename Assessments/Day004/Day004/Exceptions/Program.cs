namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Deposit(-50);
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine($"Message: {ex.Message}");
            }

            static void Deposit(decimal amount)
            {
                if(amount>0){
                    Console.WriteLine($"Valid deposit");
                }
                else{
                    throw new ArgumentOutOfRangeException($"The amount cannot be negative");
                }
            }
        }
    }
}
