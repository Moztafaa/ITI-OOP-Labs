﻿namespace Lab7;

using System.Linq;
public class Club(string name,
        int foundedYear,
        string stadium, decimal initialBudget) : IManageable
{
    public string Name { get; set; } = name;
    public int FoundedYear { get; set; } = foundedYear;
    public string Stadium { get; set; } = stadium;
    public List<Player> Players { get; set; } = new();
    public List<Coach> Coaches { get; set; } = new();
    public List<MedicalStaff> MedicalTeam { get; set; } = new();
    private decimal _budget = initialBudget;
    private Dictionary<Match, MatchResult>? _matchWithResult = new();

    // private List<Match> _matches;
    // private List<MatchResult> _matchResults;

    public void AddBudget(decimal amount)
    {
        if (amount > 0) _budget += amount;
    }

    public void AddMatchWithResult(Match match, MatchResult result)
    {
        if (match is not null && result is not null)
        {
            _matchWithResult.Add(match, result);
        }
        else
        {
            Console.WriteLine("Please enter a valid match and result");
        }
    }

    public void PrintMatchHistory(Match match)
    {
        if (_matchWithResult.ContainsKey(match))
        {
            var matchResult = _matchWithResult[match];
            Console.WriteLine(matchResult);
        }
        else
        {
            Console.WriteLine("Match not found in the history");
        }
    }

    public void AddPlayer(Player player)
    {
        if (player is not null)
        {

            Players.Add(player);
        }
        else
        {
            Console.WriteLine("Add a vaild player");
        }

    }

    public void RemovePlayer(int jerseyNumber)
    {
        var player = Players.FirstOrDefault(p => p.JerseyNumber == jerseyNumber);
        if (player is not null)
        {
            Players.Remove(player);
        }
        else
        {
            Console.WriteLine("Player not found");
        }

    }

    public override string ToString()
    {
        return $"Club Name: {Name}\nStadium: {Stadium}\nClub Budget: {_budget}";
    }

}
