using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    public class Inventory
    {
        private List<Product> products = new List<Product>();
        HashSet<int> productsIDs = new HashSet<int>();


        public Inventory(){
            
        }
        public void AddProduct(Product product){
            if (productsIDs.Add(product.Id))
            {
                products.Add(product);
            }
            else{
                throw new Exception($"The product's ID already exists in the inventory.");
            }
        }
        public Product? FindProductById(int id){
            Product result = null;
            foreach (var product in products)
            {
                if(product.Id==id){
                   result = product;
                }

            }
            if(result!=null){
                return result;
            }
            else
            {
                throw new ArgumentNullException($"The product doesn't exist");
            }

        }
        public void IncreaseStock(int id, int amount){
            Product product = FindProductById(id);
            if(product==null){
                throw new ArgumentNullException($"Unknown product");
            }
            else{
                product.IncreaseQuantity(amount);
            }
        }
        public void DecreaseStock(int id, int amount){
            Product product = FindProductById(id);
            if (product==null)
            {
                throw new ArgumentNullException($"Unknown product");
            }
            else{
                product.DecreaseQuantity(amount);
            }
        }
        public List<Product> GetOutOfStockProducts(){
            List<Product> outOfStock = new List<Product>();
            foreach (var product in products)
            {
                if (product.Quantity==0)
                {
                    outOfStock.Add(product);
                }
            }
            return outOfStock;
        }

    }
}
