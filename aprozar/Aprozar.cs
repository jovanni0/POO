using aprozar.Exceptions;
using aprozar.Products;

namespace aprozar;

public class Aprozar
{
    private List<Product> _products;
    private string _name;
    private string _email;

    public Aprozar(string name, string email)
    {
        _products = new List<Product>();
        
        _name = name;
        _email = email;
    }

    /// <summary>
    /// adds a product to the list
    /// </summary>
    public void AddProduct(Product product)
    {
        if (product.GetType() == typeof(PieceProduct))
        {
            if (product.Stock < 0 || product.Stock > 1000)
                throw new InvalidQuantityException($"invalid stock quantity: {product.Stock}");
        }
        
        if (product.GetType() == typeof(WeightProduct))
        {
            if (product.Stock < 0 || product.Stock > 100)
                throw new InvalidQuantityException($"invalid stock quantity: {product.Stock}");
        }
        
        _products.Add(product);
    }

    /// <summary>
    /// prints all products
    /// </summary>
    public void PrintProducts()
    {
        foreach(var product in _products)
            Console.WriteLine(product.ToString());
    }

    
    /// <summary>
    /// prints all products that are out of stock
    /// </summary>
    public void PrintOutOfStockProducts()
    {
        foreach (var product in _products)
        {
            if (product.Stock == 0)
                Console.WriteLine(product.ToString());
        }
    }
}