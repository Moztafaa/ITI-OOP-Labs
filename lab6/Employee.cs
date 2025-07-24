using lab6.Contracts;
namespace lab6;

public abstract class Employee(int id, string name, decimal baseSalary, DateTime joinDate) : IEmployee
{
    private readonly int _id = id;
    private readonly string? _name = name;
    private decimal _baseSalary = baseSalary;
    private readonly DateTime _joinDate = joinDate;

    public int Id { get => _id; }
    public string? Name { get; set; }

    public abstract decimal CalculateSalary();

    public int GetYearsOfService()
    {
        var currYear = DateTime.Now;
        TimeSpan timeSpan = currYear - _joinDate;
        return Convert.ToInt32(timeSpan);
    }

    public static Employee operator +(Employee emp1, int rais)
    {
        emp1._baseSalary = +rais;
        return emp1;
    }


}
