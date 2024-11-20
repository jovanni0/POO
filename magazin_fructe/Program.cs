using magazin_fructe.Exceptions;
using magazin_fructe.Fructe;

namespace magazin_fructe;

class Program
{
    static void Main(string[] args)
    {
        FruitStore store = new FruitStore();
        
        List<Fruit> fruits = new List<Fruit>()
        {
            new LocalFruit("Apple", 12.5, 120, 1, new DateOnly(2024, 12, 10), 
                "Hunedoara", "Jovanni SRL", new DateOnly(2024, 11, 19)),
            new LocalFruit("Pear", 10.99, 10, 2, new DateOnly(2024, 11, 21), 
                "Alba", "Fictive SRL", new DateOnly(2024, 11, 19)),
            new LocalFruit("Sturure", 8.89, 300, 3, new DateOnly(2024, 10, 20), 
                "Cluj", "InGroapa SRL", new DateOnly(2024, 01, 01)),
            new LocalFruit("Dovleac", 30, 7, 1, new DateOnly(2025, 3, 09), 
                "Timis", "IDK SRL", new DateOnly(2024, 09, 05)),

            new ForeignFruit("Banana", 21.99, 300, 1, new DateOnly(2025, 09, 05),
                "Spain", "Juventus SRL"),
            new ForeignFruit("Mandarina", 8.80, 120, 1, new DateOnly(2025, 03, 05),
                "Spain", "BabaIaga SRL"),
            new ForeignFruit("TricouAlb", 21.99, 300, 1, new DateOnly(2024, 09, 05),
                "Spain", "GoAway SRL"),
        };

        foreach (var fruit in fruits)
        {
            store.AddFruit(fruit);
        }

        Dictionary<string, int> sell = new Dictionary<string, int>()
        {
            { "Apple", 31 },
            { "Dovleac", 55},
            { "banana", 2},
            { "TricouAlb", 155},
        };
        foreach (var fruit in sell)
        {
            try
            {
                store.SellFruit(fruit.Key, fruit.Value);
            }
            catch (FruitNotFoundByNameException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (NotEnoughStockException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        Console.WriteLine("------------------------------------- Fructe Disponebile:");
        Console.WriteLine(string.Join("\n", store.GetAvailableFruits()));
        
        Console.WriteLine("------------------------------------- Fructe in intervalul de valabiliate 30/11/2024 - 12/01/2025:");
        var validFruits = store.GetFruitsByValability(new DateOnly(2024, 11, 30), new DateOnly(2025, 01, 12));
        Console.WriteLine(string.Join('\n', validFruits));
        
        Console.WriteLine("------------------------------------- Cel mai scump frunct importat:");
        Console.WriteLine(store.GetMostExpensiveImportedFruits());
    }
}