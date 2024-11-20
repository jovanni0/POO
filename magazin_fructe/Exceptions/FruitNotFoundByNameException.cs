namespace magazin_fructe.Exceptions;

public class FruitNotFoundByNameException : Exception
{
    public FruitNotFoundByNameException(string message) : base(message)
    {
        
    }
}