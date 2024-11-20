namespace chatgpt___1;

public class Robot
{
    private string _type;
    private int _points;

    public Robot(string type)
    {
        _type = type;
        _points = 0;
    }

    public void AddPoints(int points)
    {
        _points += points;
    }
    
    public int GetPoints() => _points;

    public override string ToString() => $"{_type}, {_points} points";
}