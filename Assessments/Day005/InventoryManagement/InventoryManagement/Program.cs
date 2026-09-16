namespace InventoryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Product zero = new Product(0, "Keyboard", 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            Product first = new Product(1, "Keyboard", 10);
            Product second = new Product(2, "Mouse", 0);
            Product third = new Product(3, "Monitor", 5);
            Product fourth = new Product(1, "Mousepad", 3);

            try
            {
                Product fifth = new Product(5, " ", 10);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            Inventory inventory = new Inventory();

            inventory.AddProduct(first);
            inventory.AddProduct(second);
            inventory.AddProduct(third);

            try
            {
                inventory.AddProduct(fourth);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            Console.WriteLine($"Product: {inventory.FindProductById(2).Name}  ID: 2");

            
            if (inventory.FindProductById(99)==null)
            {
                Console.WriteLine($"The product with ID:{99} deosn't exist");
            }

            try
            {
                inventory.IncreaseStock(1, 5);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            try
            {
                inventory.DecreaseStock(3, 2);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            try
            {
                inventory.DecreaseStock(3, 100);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }
            
            try
            {
                inventory.IncreaseStock(3, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            try
            {
                inventory.DecreaseStock(3, 0);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            try
            {
                inventory.IncreaseStock(99, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }

            try
            {
                inventory.DecreaseStock(99, 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
            }


            List<Product> outOfStock = inventory.GetOutOfStockProducts();
            foreach (var product in outOfStock)
            {
                Console.WriteLine($"{product}");
            }
        }
    }
}
