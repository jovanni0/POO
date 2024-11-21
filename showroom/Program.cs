namespace showroom;

class Program
{
    static void Main(string[] args)
    {
        Showroom showroom = new Showroom();
        
        List<Car> cars = new List<Car>()
        {
            new Hatchback("Logan", "Dacia", 12000, 2004, "second-hand"),
            new SUV("RAV4", "Toyota", 45000, 2006, "third-hand"),
            new SUV("GAS", "Kia", 80000, 2019, "new"),
            new Hatchback("Yoink", "Kia", 15000, 2002, "second-hand"),
        };

        foreach (var car in cars)
        {
            try
            {
                showroom.AddCar(car);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
        
        Console.WriteLine("------------------------ Masinile din showroom:");
        showroom.PrintCars();
        
        Console.WriteLine("------------------------ Preturile masinilor:");
        showroom.PrintPrices();
        
        Console.WriteLine("------------------------ Kia dupa 2016:");
        showroom.PrintSpecificCars("Kia", 2016);
    }
}