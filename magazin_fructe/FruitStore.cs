using magazin_fructe.Exceptions;
using magazin_fructe.Fructe;

namespace magazin_fructe;

public class FruitStore
{
    private Dictionary<string, Fruit> _fruits;

    /// <summary>
    /// default ctor
    /// </summary>
    public FruitStore()
    {
        _fruits = new Dictionary<string, Fruit>();
    }

    
    /// <summary>
    /// adds a fruit to the available list. if a fruit with the same name already exists, the quantity is increased.
    /// </summary>
    public void AddFruit(Fruit newFruit)
    {
        var fruitName = newFruit.Name;
        
        // if there already is a fruit with the same name just increase it's quantity
        if (_fruits.ContainsKey(fruitName))
            _fruits[fruitName].IncreaseQuantity(newFruit.Quantity);
        
        _fruits.Add(fruitName, newFruit);
    }

    
    /// <summary>
    /// tries to sell a specified quantity from some fruit type.
    /// </summary>
    /// <param name="fruitName"></param>
    /// <param name="quantity"></param>
    /// <exception cref="FruitNotFoundByNameException"></exception>
    /// <exception cref="NotEnoughStockException"></exception>
    public void SellFruit(string fruitName, int quantity)
    {
        if (!_fruits.ContainsKey(fruitName))
        {
            throw new FruitNotFoundByNameException($"Fruit '{fruitName}' does not exist");
        }

        if (_fruits[fruitName].Quantity < quantity)
        {
            throw new NotEnoughStockException($"Not enough stock to sell fruit '{fruitName}', requested {quantity}, available {_fruits[fruitName].Quantity}");
        }
        
        _fruits[fruitName].SellQuantity(quantity);
        if (!_fruits[fruitName].IsAvailable())
        {
            _fruits.Remove(fruitName);
            Console.WriteLine($"fruit '{fruitName}' just became out of stock");            
        }
    }


    /// <summary>
    /// list all data about the fruits available.
    /// </summary>
    public List<string> GetAvailableFruits()
    {
        var sortedFruitList = _fruits.Keys.OrderBy(fruitName => fruitName).ToList();
        
        List<string> fruitData = new List<string>();
        foreach (var fruitName in sortedFruitList)
        {
            // Console.WriteLine(_fruits[fruitName]);
            fruitData.Add(_fruits[fruitName].ToString());
        }
        
        return fruitData;
    }


    /// <summary>
    /// lists all fruit data for the fruits in the indicated availability range
    /// </summary>
    public List<string> GetFruitsByValability(DateOnly startDate, DateOnly endDate)
    {
        List<string> fruitData = new List<string>();
        
        foreach (var fruit in _fruits.Values)
        {
            if (fruit.AvailableUntil >= startDate && fruit.AvailableUntil <= endDate)
                fruitData.Add(fruit.ToString());
        }
        
        return fruitData;
    }

    /// <summary>
    /// gets the data about the most expensive imported fruit
    /// </summary>
    public string GetMostExpensiveImportedFruits()
    {
        var sortedFruits = _fruits.Values.OrderByDescending(fruit => fruit.Price).ToList();
        
        foreach(var fruit in sortedFruits)
            if (fruit.GetType() == typeof(ForeignFruit))
                return fruit.ToString();
        
        return "no imported fruit found";
    }
}