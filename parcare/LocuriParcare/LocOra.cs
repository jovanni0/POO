namespace parcare.LocuriParcare;

public class LocOra : LocParcare
{
    private double _price;
    
    public LocOra(int nrLoc, double price, bool isUsed) : base(nrLoc, isUsed, -1)
    {
        _price = price;
    }
}