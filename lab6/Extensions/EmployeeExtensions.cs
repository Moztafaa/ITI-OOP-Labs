
using lab6.Contracts;

namespace lab6.Extensions;

public static class EmployeeExtensions
{

    public static string GetEmployeeInfo(this IEmployee employee)
    {
        return $"Employee Id {employee.Id}, Employee Name: {employee.Name}";
    }

    public static bool IsEligibleForPromotion(this IEmployee employee)
    {
        if (employee is IPromotable promotable)
        {
            return promotable.IsEligibleForPromotion();
        }


        return false;
    }

}
