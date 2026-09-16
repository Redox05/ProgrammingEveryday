using System;
using System.Collections.Generic;
using System.Text;

namespace InventoryManagement
{
    public class Product
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }

        void SetId(int id){
            if(int.IsNegative(id) || id==0){
                throw new ArgumentException($"Id cannot be negative or zero");
            }
            else{
                Id = id;
            }
        }
        void SetName(string name){
            if(string.IsNullOrWhiteSpace(name)){
                throw new ArgumentNullException($"Name cannot be empty");
            }
            else{
                Name = name;
            }
        }
        void SetQuantity(int quantity){
            if (int.IsNegative(quantity))
            {
                throw new ArgumentException($"Quantity cannot be negative");
            }
            else{
                Quantity = quantity;
            }
        }
        public Product(int id, string name, int quantity){
            SetId(id);
            SetName(name);
            SetQuantity(quantity);
        }
        public void IncreaseQuantity(int amount){
            if(int.IsNegative(amount) || amount==0){
                throw new ArgumentOutOfRangeException($"The amount must be positive greater than zero");
            }
            else{
                Quantity += amount;
            }
        }
        public void DecreaseQuantity(int amount){
            if (int.IsNegative(amount) || amount==0)
            {
                throw new ArgumentOutOfRangeException($"Amount cannot be negative or zero. Please " +
                $"enter a positive number to substract from the stock");
            }
            else if(amount>Quantity){
                throw new ArgumentOutOfRangeException($"The amount cannot be larger than the current stock");
            }
            else
            {
                Quantity -= amount;
            }
        }

    }
}
