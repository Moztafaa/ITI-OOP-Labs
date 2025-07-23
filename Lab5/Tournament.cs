namespace Lab5;

public class Tournament(string name, decimal prizePool) : ITournament
{
    public string Name { get; set; } = name;
    public decimal PrizePool { get; set; } = prizePool;

    public decimal CalculatePrize(bool isWinner)
    {
        return isWinner ? PrizePool * 0.6m : PrizePool * 0.4m;
    }
}