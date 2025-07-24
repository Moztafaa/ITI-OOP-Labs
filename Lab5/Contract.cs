using Lab5.Contracts;

namespace Lab5;

public class Contract(IPlayer player, DateTime startDate, DateTime endDate, decimal weeklySalary)
    : IContract, ITestabel
{
    public IPlayer Player { get; set; } = player;
    public DateTime StartDate { get; set; } = startDate;
    public DateTime EndDate { get; set; } = endDate;
    public decimal WeeklySalary { get; set; } = weeklySalary;

    public decimal CalculateSalary()
    {
        return WeeklySalary * 52m;
    }

    public bool IsActive()
    {
        DateTime currentDate = DateTime.Now;
        return currentDate >= StartDate && currentDate <= EndDate;
    }
}