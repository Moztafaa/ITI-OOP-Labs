namespace lab6;

using lab6.Contracts;
public class Department(decimal budget) : IDepartment
{
    public List<IEmployee> employees { get; set; } = new();
    private decimal _budget = budget;

    public void AddEmployee(IEmployee employee)
    {
        employees.Add(employee);
    }

    public void GeneratePayroll()
    {
    }
    public static string GetDepartmentCode()
    {
        return IDepartment.GetDepartmentCode();
    }

    public static Department operator +(Department dept, decimal bud)
    {
        dept._budget += bud;
        return dept;
    }
}
