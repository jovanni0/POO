using System.ComponentModel.Design;
using chatgpt___1.Exceptions;

namespace chatgpt___1;

public class CompetitionService
{
    private List<Competition> _competitions;
    private bool _competitionsHappened = false;

    /// <summary>
    /// default constructor
    /// </summary>
    public CompetitionService()
    {
        _competitions = new List<Competition>();
    }

    /// <summary>
    /// adds a competition
    /// </summary>
    public void AddCompetition(Competition competition)
    {
        _competitions.Add(competition);
    }

    /// <summary>
    /// attempts to add a team to a competition
    /// </summary>
    public void AddTeamToCompetition(Team team, string competitionName)
    {
        var random = new Random();
        if (random.Next(0, 5) == 0)
            throw new ServiceOfflineException("the service is offline");
        
        if (team.GetMembersCount() < 2)
            throw new TeamNotEligibleException($"the team doesn't have enough members ({team.GetMembersCount()}/2)");
        
        foreach (var item in _competitions)
        {
            if (item.GetName() == competitionName)
            {
                item.AddTeam(team);
                return;
            }
        }
        throw new CompetitionNotFoundException($"Competition {competitionName} not found");
    }

    /// <summary>
    /// simulates the competition
    /// </summary>
    public void StartCompetitions()
    {
        Console.WriteLine("starting competitions");
        
        var random = new Random();
        
        foreach (var competition in _competitions)
        {
            foreach (var team in competition.GetTeams())
            {
                team.GetRobot().AddPoints(random.Next(-10, 100));
            }
        }
        
        _competitionsHappened = true;
    }

    /// <summary>
    /// prints the results of the competition
    /// </summary>
    public void ShowResults()
    {
        if (!_competitionsHappened)
        {
            Console.WriteLine("competitions did not happen");
            return;
        }

        foreach (var competition in _competitions)
        {
            Console.WriteLine($"{competition.GetName()}: ----------");
            competition.CreateLeaderboard();
        }
    }
}