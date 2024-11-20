namespace magazin_fructe.Fructe;

public class LocalFruit : Fruit
{
    private string _judetProvenienta;
    private string _producator;
    private DateOnly _dataCulegere;
    
    
    /// <summary>
    /// default ctor
    /// </summary>
    public LocalFruit(string name, double price, int quantity, int quality, DateOnly availableUntil,
        string judetProvenienta, string producator, DateOnly dataCulegere) 
        : base(name, price, quantity, quality, availableUntil)
    {
        _judetProvenienta = judetProvenienta;
        _producator = producator;
        _dataCulegere = dataCulegere;
    }

    public override string ToString()
        => $"{Name}, quality: {Quality}, quantity: {Quantity}, price: {Price}, " +
           $"judet: {_judetProvenienta}, producator: {_producator}, data culegere: {_dataCulegere.ToString()}";
}