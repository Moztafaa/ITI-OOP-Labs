namespace lab6.Contracts;

public interface IDepartment
{
    void AddEmployee(IEmployee employee);
    void GeneratePayroll();
    static string GetDepartmentCode()
    {
        Guid code = Guid.NewGuid();
        return code.ToString();
    }


}
