using Day006ProductApi.Models;

namespace Day006ProductApi
{
    
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");


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

            app.Run();
        }
    }
}
