namespace Lab5;

public interface IContract
{
    public IPlayer Player { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal WeeklySalary { get; set; }
    public decimal CalculateSalary();
    public bool IsActive();
    
}