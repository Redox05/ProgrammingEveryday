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
                Product? existingProduct = products.FirstOrDefault(product => product.Id == id);
                if(existingProduct == null){
                    return Results.NotFound("The product doesn't exist");
                }
                else{
                    return Results.Ok(existingProduct);
                }
            });
            app.MapPost("/products", (Product newProduct) =>
            {
                // your implementation
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
                    int lastID = 0;
                    foreach (var product in products)
                    {
                        if (product.Id>lastID)
                        {
                            lastID = product.Id;
                        }
                    }
                    newProduct.Id = lastID + 1;
                    products.Add(newProduct);
                    return Results.Created();
                }
            });

            app.Run();
        }
    }
}
