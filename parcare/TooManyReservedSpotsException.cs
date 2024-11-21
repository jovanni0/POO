namespace parcare;

public class TooManyReservedSpotsException : Exception
{
    public TooManyReservedSpotsException(string message) : base(message)
    {
        
    }
}