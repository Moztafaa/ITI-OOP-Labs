namespace Lab5;

public abstract class MatchResult(ITournament tournament, Club homeTeam, Club awayTeam, int goalCountHome, int goalCountAway)
{
    /*
     * prop: ITournament, Home team and Away team "club", Goal counts int
     * methods: DisplayResult(), CalculatePoints()
     */
    
    public ITournament Tournament { get; set; } = tournament;
    public Club HomeTeam { get; set; } = homeTeam;
    public Club AwayTeam { get; set; } = awayTeam;
    public int GoalCountHome { get; set; } = goalCountHome;
    public int GoalCountAway { get; set; } = goalCountAway;

    public virtual void DisplayResult()
    {
        Console.WriteLine($"{HomeTeam.Name} {GoalCountHome} - {GoalCountAway} {AwayTeam.Name}");
    }
    
    public abstract void CalculatePoints();
}