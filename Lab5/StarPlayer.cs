namespace Lab5;

public class StarPlayer(string name, int age, string position, double rating) : Player(name, age, position, rating)
{
    public override decimal CalculateValue()
    {
        return base.CalculateValue() * 2;
    }
    public decimal CalculateBrandValue()
    {
        return CalculateValue() * 0.3m;
    }
}