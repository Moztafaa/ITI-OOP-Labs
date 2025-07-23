namespace Lab5;

public class Win(ITournament tournament, Club homeTeam, Club awayTeam, int goalCountHome, int goalCountAway) : MatchResult(tournament, homeTeam, awayTeam, goalCountHome, goalCountAway)
{
    public override void CalculatePoints()
    {
        HomeTeam.Points += 3;
        AwayTeam.Points += 0;

        DisplayResult();
    }
}