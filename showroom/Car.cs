namespace showroom;

public abstract class Car
{
    public string Model { get; init; }
    public string Make { get; init; }
    public  double Price { get; init; }
    public int Year { get; init; }
    public string State { get; init; }

    public Car(string model, string make, double price, int year, string state)
    {
        Model = model;
        Make = make;
        Price = price;
        Year = year;
        State = state;
    }
    
    public abstract double GetPrice();
    
    public override string ToString() => $"Model: {Model}, Marca: {Make}, Pret: {Price}, An Fabricatie: {Year}, Stare: {State}";
}