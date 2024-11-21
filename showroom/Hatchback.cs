namespace showroom;

public class Hatchback : Car
{
    public Hatchback(string model, string make, double price, int year, string state)
    : base(model, make, price, year, state)
    {
        
    }

    /// <summary>
    /// returns the price of the car, with -5% for second-hand 
    /// </summary>
    /// <returns></returns>
    public override double GetPrice()
    {
        if (State == "second-hand")
            return Price * 0.95;

        return Price;
    }
}