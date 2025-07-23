namespace Lab5;

class Program
{
    static void Main(string[] args)
    {

        Player p1 = new Player("Mohamed Salah", 32, "Forward", 9.5);
        StarPlayer p2 = new StarPlayer("Cristiano Ronaldo", 39, "Forward", 9.8);
        SponsoredPlayer p3 =
            new SponsoredPlayer("Lionel Messi", 37, "Forward", 9.9, "Adidas", 2_000_000, "Adidas", 1_000_000);
        Player p4 = new Player("Karim Benzema", 36, "Forward", 9.2);
        StarPlayer p5 = new StarPlayer("Kylian Mbappé", 26, "Forward", 9.7);
        SponsoredPlayer p6 = new SponsoredPlayer("Neymar Jr.", 33, "Midfielder", 9.3, "Puma", 1_500_000, "Puma", 900_000);

        Contract c1 = new Contract(p1, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1), 500_000);
        Contract c2 = new Contract(p2, DateTime.Now.AddYears(-2), DateTime.Now.AddYears(2), 1_000_000);
        Contract c3 = new Contract(p3, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1), 1_200_000);
        Contract c4 = new Contract(p4, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(2), 800_000);
        Contract c5 = new Contract(p5, DateTime.Now.AddYears(-2), DateTime.Now.AddYears(1), 1_100_000);
        Contract c6 = new Contract(p6, DateTime.Now.AddYears(-1), DateTime.Now.AddYears(1), 950_000);

        Club club1 = new Club("Al Ahly", 10_000_000);
        Club club2 = new Club("Zamalek", 8_000_000);
        Club club3 = new Club("Real Madrid", 12_000_000);
        Club club4 = new Club("Paris Saint-Germain", 15_000_000);

        club1.AddPlayer(p1, c1);
        club1.AddPlayer(p2, c2);
        club2.AddPlayer(p3, c3);
        club3.AddPlayer(p4, c4);
        club3.AddPlayer(p5, c5);
        club4.AddPlayer(p6, c6);

        var p1Value = p1.CalculateValue();
        var p2Value = p2.CalculateValue();
        var p2Brand = p2.CalculateBrandValue();
        var p3Value = p3.CalculateValue();
        var p3Sponsor = p3.Sponsor;
        var p3Sponsorship = p3.SponsorshipAmount;
        var p3Earnings = p3.CalculateTotalEarnings(c3);

        var club1InitialAvgRating = club1.CalculateAverageRating();
        var club1InitialForwards = club1.CountPlayersByPosition("Forward");

        club1.RemovePlayer(p1);
        var club1BudgetAfterRemove = club1.Budget;

        Club merged = club1 + club2;

        Tournament championsLeague = new Tournament("Champions League", 5_000_000);
        var winnerPrize = championsLeague.CalculatePrize(true);
        var loserPrize = championsLeague.CalculatePrize(false);

        Win match1 = new Win(championsLeague, club1, club2, 3, 1);
        Lose match2 = new Lose(championsLeague, club2, club1, 1, 0);
        match1.CalculatePoints();
        match2.CalculatePoints();
        var club1Points = club1.Points;
        var club2Points = club2.Points;

        var club3AvgRating = club3.CalculateAverageRating();
        var club4AvgRating = club4.CalculateAverageRating();
        var club3Forwards = club3.CountPlayersByPosition("Forward");
        var club4Midfielders = club4.CountPlayersByPosition("Midfielder");

        Console.WriteLine("--- Player Information ---");
        Console.WriteLine($"{p1.Name} Value: {p1Value}");
        Console.WriteLine($"{p2.Name} Value: {p2Value} (Brand: {p2Brand})");
        Console.WriteLine($"{p3.Name} Value: {p3Value} (Sponsor: {p3Sponsor}, Sponsorship: {p3Sponsorship})");
        Console.WriteLine($"{p3.Name} Total Earnings: {p3Earnings}");
        Console.WriteLine();

        Console.WriteLine("--- Club Information ---");
        Console.WriteLine($"{club1.Name} Initial Avg Rating: {club1InitialAvgRating}");
        Console.WriteLine($"{club1.Name} Initial Forwards: {club1InitialForwards}");
        Console.WriteLine($"{club1.Name} Budget after removing {p1.Name}: {club1BudgetAfterRemove}");
        Console.WriteLine($"Merged Club: {merged.Name}, Players: {merged.Players.Count}");
        Console.WriteLine();

        Console.WriteLine("--- New Club Information ---");
        Console.WriteLine($"{club3.Name} Avg Rating: {club3AvgRating}");
        Console.WriteLine($"{club4.Name} Avg Rating: {club4AvgRating}");
        Console.WriteLine($"{club3.Name} Forwards: {club3Forwards}");
        Console.WriteLine($"{club4.Name} Midfielders: {club4Midfielders}");
        Console.WriteLine();

        Console.WriteLine("--- Tournament & Match Results ---");
        Console.WriteLine($"Winner Prize: {winnerPrize}");
        Console.WriteLine($"Loser Prize: {loserPrize}");
        Console.WriteLine($"{club1.Name} Points: {club1Points}");
        Console.WriteLine($"{club2.Name} Points: {club2Points}");
        Console.WriteLine("\n--- End of Program ---");
    }
}