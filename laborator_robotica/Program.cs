using chatgpt___1.Exceptions;

namespace chatgpt___1;


class Program
{
    static void Main(string[] args)
    {
        CompetitionService comSer = new CompetitionService();
        
        comSer.AddCompetition(new Competition("SmashChamps", new DateOnly(2025, 05, 23)));
        comSer.AddCompetition(new Competition("OutTheWindow", new DateOnly(2025, 04, 11)));
        
        var team1 = new Team("Team 1", new Robot("Robot 1"));
        team1.AddMember("Dodo Mihai");
        team1.AddMember("Crisanul Alex");
        var team2 = new Team("Team 2", new Robot("Robot 2"));
        team2.AddMember("Molnar Rares");
        var team3 = new Team("Team 3", new Robot("Robot 3"));
        team3.AddMember("Popescu Cosmin");
        team3.AddMember("Avram Maria");
        team3.AddMember("Popescu Dora");
        var team4 = new Team("Team 4", new Robot("Robot 4"));
        team4.AddMember("Victor Andrei");
        
        List<Tuple<Team, string>> toadd = new List<Tuple<Team, string>>()
        {
            new Tuple<Team, string>(team1, "SmashChamps"),
            new Tuple<Team, string>(team2, "OutTheWindow"),
            new Tuple<Team, string>(team3, "OutTheWindow"),
            new Tuple<Team, string>(team4, "OutTheWindow"),
            new Tuple<Team, string>(team4, "SmashChamps"),
            new Tuple<Team, string>(team1, "NoComp"),
        };

        foreach (var team in toadd)
        {
            try
            {
                comSer.AddTeamToCompetition(team.Item1, team.Item2);
                Console.WriteLine($"team {team.Item1.GetName()} has been added to competition {team.Item2}");
            }
            catch (ServiceOfflineException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (TeamNotEligibleException e)
            {
                Console.WriteLine($"{team.Item1.GetName()}: {e.Message}");
            }
            catch (CompetitionNotFoundException e)
            {
                Console.WriteLine($"{team.Item1.GetName()}: {e.Message}");
            }
        }
        
        comSer.ShowResults();
        comSer.StartCompetitions();
        comSer.ShowResults();
        
    }
}