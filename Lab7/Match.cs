namespace Lab7;

public class Match(string opponent, DateTime date, string venue)
{
    public string Opponent { get; set; } = opponent;
    public DateTime Date { get; set; } = date;
    public string Venue { get; set; } = venue;

}
