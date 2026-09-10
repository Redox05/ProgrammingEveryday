namespace Day002BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            BankAccount savings1 = new SavingsAccount("S001", "Pepe", 10000m, 0.05m);
            BankAccount checking1 = new CheckingAccount("C001", "Pipi", 20000m, 1m);

            accounts.Add(savings1);
            accounts.Add(checking1);

            foreach(var ac in accounts){
                Console.WriteLine($"Owner: {ac.Owner}  Balance: ${ac.Balance}   Monthly Benefit: {ac.CalculateMonthlyBenefit()}");
            }
        }
    }
}
