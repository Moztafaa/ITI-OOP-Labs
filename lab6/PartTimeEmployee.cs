namespace lab6;

public class PartTimeEmployee(int id, string name, decimal baseSalary, DateTime joinDate, int hoursWorked, decimal hourlyRate) : Employee(id, name, baseSalary, joinDate), ISalaried, IPromotable
{

    private readonly int _hoursWorked = hoursWorked;
    private readonly decimal _hourlyRate = hourlyRate;

    public override decimal CalculateSalary()
    {
        var sal = _hoursWorked * _hourlyRate;
        return sal;
    }

    public bool IsEligibleForPromotion()
    {
        return _hoursWorked > 100;
    }
}
