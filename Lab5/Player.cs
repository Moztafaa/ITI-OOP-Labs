namespace Lab5;

public class Player(string name, int age, string position, double rating)
    : IPlayer
{
    public string Name { get; set; } = name;
    public int Age { get; set; } = age;
    public string Position { get; set; } = position;
    public double Rating { get; set; } = rating;

    public virtual decimal CalculateValue()
    {
        return (decimal)(Rating * 1_000_000);
    }
    
    public virtual decimal CalculateValue(double multiplier)
    {
        return (decimal)(Rating * 1_000_000 * multiplier);
    }
}