

using Lab7;

var club1 = new Club("Manchester United", 1856, "Old Traford", 100_000_000_000m);

var player1 = new Player("Right Wing", 11, 5.0, "Lamine Yamal", 18);
var player2 = new Player("Defender", 2, 3.2, "Hakimi", 24);

player1.UpdateSalary(23_000_000);
player2.UpdateSalary(3_000_000);

club1.AddPlayer(player1);
club1.AddPlayer(player2);


var coach1 = new Coach("A", "3-4-3", "Xavi Alonso", 45);

var midicalStaff1 = new MedicalStaff("Doctor", "Sherif", 39);

club1.Coaches.Add(coach1);
club1.MedicalTeam.Add(midicalStaff1);

var match1 = new Match("Man City", DateTime.Today, club1.Stadium);

var match1Result = new MatchResult("Man City", DateTime.Today, 3, 1);


club1.AddMatchWithResult(match1, match1Result);


Console.WriteLine("=== Football Club Management System ===\n\n");

Console.WriteLine(club1);
Console.WriteLine();

Console.WriteLine("Player:");
var players = club1.Players;

foreach (var player in players)
{
    Console.WriteLine(player.DisplayInfo());
}
Console.WriteLine();
Console.WriteLine("Coaching Staff:");
foreach (var coach in club1.Coaches)
{
    Console.WriteLine(coach);
}
Console.WriteLine();

Console.WriteLine("Medical Team:");
foreach (var member in club1.MedicalTeam)
{
    Console.WriteLine(member.DisplayInfo());
}
Console.WriteLine();
club1.PrintMatchHistory(match1);
Console.WriteLine();

Console.WriteLine($"Original: {match1Result}");

var match1ResultUpdate = match1Result with { GoalsScored = 2 };

Console.WriteLine($"Updated: {match1ResultUpdate}");
