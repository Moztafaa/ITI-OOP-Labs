namespace Lab5;

public interface IPlayer
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
    public double Rating { get; set; }


    public decimal CalculateValue(double multiplier);

    public decimal CalculateValue();
}