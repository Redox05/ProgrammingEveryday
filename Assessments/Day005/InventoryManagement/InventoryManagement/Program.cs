namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product first = new Product(1, "Keyboard", 10);
            Product second = new Product(2, "Mouse", 0);
            Product third = new Product(3, "Monitor", 5);
            //Product fourth = new Product(1, "Mousepad", 3);

            Inventory inventory = new Inventory();

            inventory.AddProduct(first);
            inventory.AddProduct(second);
            inventory.AddProduct(third);
            //inventory.AddProduct(fourth);

            //Console.WriteLine($"Product: {inventory.FindProductById(2).Name}  ID: 2");

            //inventory.IncreaseStock(1, 0);
            //inventory.DecreaseStock(10, 2);
            //inventory.DecreaseStock(3, 100);

            inventory.GetOutOfStockProducts(); 

        }
    }
}
