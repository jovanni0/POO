namespace magazin_fructe.Fructe;

public abstract class Fruit
{
    public string Name { get; init; }
    public double Price { get; init; }
    public int Quantity { get; private set; }
    public int Quality { get; init; }
    public DateOnly AvailableUntil { get; init; }

    public Fruit(string name, double price, int quantity, int quality, DateOnly availableUntil)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
        Quality = quality;
        AvailableUntil = availableUntil;
    }
    
    public bool IsAvailable() => Quantity > 0;
    
    public void SellQuantity(int quantity) => Quantity -= quantity;
    
    public void IncreaseQuantity(int quantity) => Quantity += quantity;
}