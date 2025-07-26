namespace Lab7;

public record class MatchResult(string Opponent, DateTime Date, int GoalsScored, int GoalsConceded)
{
    public override string ToString()
    {
        return $"{Date}: vs {Opponent} - {GoalsScored}-{GoalsConceded}";
    }
}
