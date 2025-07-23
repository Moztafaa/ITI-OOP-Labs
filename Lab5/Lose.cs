namespace Lab5;

public class Lose(ITournament tournament, Club homeTeam, Club awayTeam, int goalCountHome, int goalCountAway) : MatchResult(tournament, homeTeam, awayTeam, goalCountHome, goalCountAway)
{
    public override void CalculatePoints()
    {
        HomeTeam.Points += 0;
        AwayTeam.Points += 3;

        DisplayResult();
    }
}