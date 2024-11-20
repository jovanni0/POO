namespace magazin_fructe.Fructe;

public class ForeignFruit : Fruit
{
    private string _originCountry;
    private string _importer;
    
    /// <summary>
    /// default ctor
    /// </summary>
    public ForeignFruit(string name, double price, int quantity, int quality, DateOnly availableUntil, string originCountry, string importer) 
        : base(name, price, quantity, quality, availableUntil)
    {
        _originCountry = originCountry;
        _importer = importer;
    }
    
    
    public override string ToString()
        => $"{Name}, quality: {Quality}, quantity: {Quantity}, price: {Price}, " +
           $"tara origine: {_originCountry}, importattor: {_importer}";
    
}