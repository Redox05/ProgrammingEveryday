using Day006ProductApi.Models;

namespace Day006ProductApi
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            List<Product> products = new List<Product>
            {
                new Product {Id=1, Name="Keyboard",Quantity=10},
                new Product {Id=2, Name="Mouse", Quantity=0},
                new Product {Id=3, Name="Monitor", Quantity=5}
            };

            app.MapGet("/products", () => {
                return products;
            });

            app.MapGet("/products/{id}", (int id) =>
            {
                Product? existingProduct = null;

                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id==id)
                    {
                        existingProduct = products[i];
                    }
                }
                if(existingProduct == null){
                    return Results.NotFound("The product doesn't exist");
                }
                else{
                    return Results.Ok(existingProduct);
                }
            });
            app.MapPost("/products", (Product newProduct) =>
            {
                if (string.IsNullOrWhiteSpace(newProduct.Name))
                {
                    return Results.BadRequest("Name cannot be null, empty, or whitespace");
                }
                else if (newProduct.Quantity<0)
                {
                    return Results.BadRequest("Quantity cannot be neggative");
                }
                else
                {
                    for (int i = 0; i < products.Count; i++)
                    {
                        if (newProduct.Id==products[i].Id)
                        {
                            return Results.BadRequest("That ID is not available. Select a different ID");
                        }
                    }
                    products.Add(newProduct);
                    return Results.Created();
                }
            });


            app.MapPut("/products/{id}", (int id, Product updatedProduct) =>
            {
                Product? existingProduct = null;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id==id)
                    {
                        existingProduct = products[i];
                        break;
                    }
                }
                if (existingProduct==null)
                {
                    return Results.NotFound("The product doesn't exist");
                }
                if (string.IsNullOrWhiteSpace(updatedProduct.Name))
                {
                    return Results.BadRequest("Name cannot be bull, empty, or whitespace");
                }
                if (int.IsNegative(updatedProduct.Quantity))
                {
                    return Results.BadRequest("Quantity cannot be negative");
                }
                existingProduct.Name = updatedProduct.Name;
                existingProduct.Quantity = updatedProduct.Quantity;
                return Results.Ok("The product was modified");

            });

            app.MapDelete("/products/{id}", (int id) =>
            {
                Product? existingProduct = null;
                for (int i = 0; i < products.Count; i++)
                {
                    if (products[i].Id==id)
                    {
                        existingProduct = products[i];
                        break;
                    }
                }
                if (existingProduct==null)
                {
                    return Results.NotFound("The product doesn't exist.");
                }
                products.Remove(existingProduct);
                return Results.NoContent();
            });
            app.Run();
        }
    }
}
