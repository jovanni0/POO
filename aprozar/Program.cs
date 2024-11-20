using aprozar.Exceptions;
using aprozar.Products;

namespace aprozar;

class Program
{
    static void Main(string[] args)
    {
        Aprozar aprozar = new Aprozar("amazing aprozar", "amazingaprozar@gmail.com");
        
        List<Product> products = new List<Product>()
        {
            new PieceProduct("morcov", 0.16, 3.0, 31),
            new WeightProduct("mandarina", 8.65, "kg", 10.2),
            new WeightProduct("mar", 1.25, "kg", 0),
            new PieceProduct("para", 0.22, 2.99, 0),
            new PieceProduct("portocala", 0.28, 2.99, 1500)
        };

        foreach (Product product in products)
        {
            try
            {
                aprozar.AddProduct(product);
            }
            catch (InvalidQuantityException e)
            {
                Console.WriteLine(e);
            }
        }
        
        Console.WriteLine("--------------------------- afisaza toate produsele:");
        aprozar.PrintProducts();
        
        Console.WriteLine("---------------------------- produsele cu stoc zero:");
        aprozar.PrintOutOfStockProducts();
    }
}