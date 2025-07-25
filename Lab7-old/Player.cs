namespace Lab7;

public class Player : Person
{
    public string Position { get; set; }
    public int JerseyNumber { get; set; }
    public double SkillRating { get; set; }
    public decimal Salary { get; }
    public List<Match> Matchs { get; set; }




    public void UpdateSalary(decimal amount)
    {
        if (amount < Salary)
        {
            Console.WriteLine("The updated Salary is less than Old Salary!");
        }
        else
        {
            Salary = amount;
        }

    }




}
