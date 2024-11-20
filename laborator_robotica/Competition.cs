namespace chatgpt___1;

public class Competition
{
    private string _name;
    private DateOnly _date;
    private List<Team> _teams;

    public Competition(string name, DateOnly date)
    {
        _name = name;
        _date = date;
        
        _teams = new List<Team>();
    }

    /// <summary>
    /// add a team to the competition
    /// </summary>
    public void AddTeam(Team team)
    {
        _teams.Add(team);
    }

    /// <summary>
    /// creats and prints the leaderboard
    /// </summary>
    public void CreateLeaderboard()
    {
        _teams.Sort((x, y) => y.GetPoints().CompareTo(x.GetPoints()));
        Console.WriteLine(string.Join("\n", _teams.Select(x => x.ToString())));
    }
    
    public string GetName() => _name;
    
    public List<Team> GetTeams() => _teams;
}