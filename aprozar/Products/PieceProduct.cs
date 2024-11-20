namespace aprozar.Products;

public class PieceProduct : Product
{
    /// <summary>
    /// the weight of one piece
    /// </summary>
    public double Quantity { get; private set; }
    
    public PieceProduct(string name, double quantity, double unitPrice, double stock)
    : base(name, unitPrice, stock)
    {
        Quantity = quantity;
    }
}