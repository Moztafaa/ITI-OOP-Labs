namespace Lab5;

public static class ClubExtensions
{
    
    public static decimal CalculateAverageRating(this Club club)
    {
        var totalRating = club.Players.Sum(player => player.Rating);
        return (decimal)(totalRating / club.Players.Count);
    }
    
    public static int CountPlayersByPosition(this Club club, string position)
    {
        return club.Players.Count(player => player.Position.Equals(position));
    }
}