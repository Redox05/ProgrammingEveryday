
using RandomPointsChallenge.Models;

namespace RandomPointsChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.MapGet("/points", () =>
            {
                Random random = new Random();
                int randomN = random.Next(50, 101);

                List<Point> randomPoints = new List<Point>();

                for (int i = 0; i < randomN; i++)
                {
                    int generatedX = random.Next(0, 101);
                    int generatedY = random.Next(0, 101);

                    Point generatedPoint = new Point(generatedX, generatedY);

                    randomPoints.Add(generatedPoint);
                }
                Console.WriteLine($"Requested points: {randomN}, Generated points: {randomPoints.Count}");

                return Results.Ok(randomPoints);
            });
            
            app.Run();
        }
    }
}
