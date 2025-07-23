namespace Lab5;

public interface ITournament
{
    public string Name { get; set; }
    public decimal PrizePool { get; set; }
    public decimal CalculatePrize(bool isWinner);
}