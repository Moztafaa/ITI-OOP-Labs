namespace lab6;

public class Contractor(int id, string name, decimal baseSalary, DateTime joinDate, int contractDuration, decimal monthlyRate) : Employee(id, name, baseSalary, joinDate), ISalaried
{
    public int ContractDuration { get; private set; } = contractDuration;
    public decimal MonthlyRate { get; private set; } = monthlyRate;
    public override decimal CalculateSalary()
    {
        return MonthlyRate * ContractDuration;
    }
}
