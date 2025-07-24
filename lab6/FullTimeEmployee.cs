
namespace lab6;

public class FullTimeEmployee(int id, string name, decimal baseSalary, DateTime joinDate)
    : Employee(id, name, baseSalary, joinDate), ISalaried, IBonusEligible
{
    public decimal BaseSalary = baseSalary;

    public decimal CalculateBonus()
    {
        return CalculateSalary() * 0.1m;

    }

    public override decimal CalculateSalary()
    {
        return BaseSalary;
    }
    public decimal CalculateSalary(decimal performanceFactor)
    {
        return this.CalculateSalary() * performanceFactor;
    }
}
