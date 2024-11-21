namespace showroom;

public class SUV : Car
{
    public SUV(string model, string make, double price, int year, string state)
        : base(model, make, price, year, state)
    {
        
    }

    /// <summary>
    /// returns the price of the car, with +1000 tax
    /// </summary>
    /// <returns></returns>
    public override double GetPrice()
    {
        return Price + 1000;
    }
}