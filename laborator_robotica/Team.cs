namespace chatgpt___1;

public class Team
{
    private string _name;
    private Robot _robot;
    private List<string> _members;
    
    public Team(string teamName, Robot robot)
    {
        _name = teamName;
        _robot = robot;
        
        _members = new List<string>();
    }

    public void AddMember(string member)
    {
        _members.Add(member);
    }
    
    public int GetMembersCount() => _members.Count;
    
    public Robot GetRobot() => _robot;

    public int GetPoints() => _robot.GetPoints();
    
    public string GetName() => _name;

    public override string ToString() => $"{_name}, robot: {_robot}";
}