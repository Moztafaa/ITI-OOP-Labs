namespace Lab7;

public class Player(string position, int jerseyNumber, double skillRating, string name, int age) : Person(name, age)
{
    public string Position { get; set; } = position;
    public int JerseyNumber { get; set; } = jerseyNumber;
    public double SkillRating { get; set; } = skillRating;
    private decimal _salary;

    public decimal Salary { get => _salary; }

    public void UpdateSalary(decimal amount)
    {
        if (amount < Salary)
        {
            Console.WriteLine("The updated Salary is less than Old Salary!");
        }
        else
        {
            _salary = amount;
        }

    }

    public override string ToString()
    {
        return $"He is {typeof(Player)}";
    }

    public override string DisplayInfo()
    {
        return $"Player Position is {Position}";
    }
}
