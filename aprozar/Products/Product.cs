namespace aprozar.Products;

public abstract class Product
{
    /// <summary>
    /// the name of the product
    /// </summary>
    public string Name { get; init; }
    
    /// <summary>
    /// the price of one unit of the product 
    /// </summary>
    public double UnitPrice { get; init; }
    
    /// <summary>
    /// how much of a product is available
    /// </summary>
    public double Stock { get; protected set; }

    public Product(string name, double unitPrice, double stock)
    {
        Name = name;
        UnitPrice = unitPrice;
        Stock = stock;
    }

    public override string ToString()
    {
        return $"Name: {Name}, UnitPrice: {UnitPrice}, Stock: {Stock}";
    }
}