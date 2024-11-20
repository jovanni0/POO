namespace magazin_fructe.Exceptions;

public class NotEnoughStockException : Exception
{
    public NotEnoughStockException(string message) : base(message)
    {
        
    }
}