namespace showroom;

public class Showroom
{
    private List<Car> cars;

    public Showroom()
    {
        cars = new List<Car>();
    }

    /// <summary>
    /// adds a car to the showroom
    /// </summary>
    /// <param name="car"></param>
    public void AddCar(Car car)
    {
        if (car.Model.Length > 20)
            throw new Exception("Modelul nu trebuie sa fie mai mung de 20 caractere");
        if (car.Make.Length > 20)
            throw new Exception("Modelul nu trebuie sa fie mai mung de 20 caractere");
        if (car.Price < 3000)
            throw new Exception("Pretul nu trebuie sa fie mai mic de 3000");
        if (car.Year > 2024)
            throw new Exception("Anul de fabricatie nu poate sa fie din viitor");
        if (car.State != "new" && car.State != "second-hand")
            throw new Exception("Starea masinii poate fi doar 'new' sau 'second-hand'");
        
        cars.Add(car);
    }

    /// <summary>
    /// prints data for all car
    /// </summary>
    public void PrintCars()
    {
        Console.WriteLine(string.Join("\n", cars.Select(car => car.ToString())));
    }
    
    /// <summary>
    /// prints data for all car, plus prices
    /// </summary>
    public void PrintPrices()
    {
        Console.WriteLine(string.Join("\n", cars.Select(car => $"{car.ToString()}, Price: {car.GetPrice()}")));
    }

    
    /// <summary>
    /// prints only the cars with the specifies parameters
    /// </summary>
    /// <param name="make"></param>
    /// <param name="fromYear"></param>
    public void PrintSpecificCars(string make, int fromYear)
    {
        foreach (var car in cars)
        {
            if (car.Make == make && car.Year >= fromYear)
                Console.WriteLine(car.ToString());
        }
    }
}