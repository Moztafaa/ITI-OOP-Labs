namespace Lab5;

public class Club(string name, decimal budget)
{
    public string Name { get; set; } = name;


    public int Points { get; set; } = 0;
    public decimal Budget { get; set; } = budget;
    public List<IPlayer> Players { get; set; } = new();
    private List<IContract> Contracts { get; set; } = new();


    public void AddPlayer(IPlayer player, IContract contract)
    {
        // if (contract.CalculateSalary() > Budget)
        // {
        //     throw new InvalidOperationException("مفيـش فلوس");
        // }

        Players.Add(player);
        Contracts.Add(contract);
        Budget -= contract.CalculateSalary();
    }

    public void RemovePlayer(IPlayer player)
    {
        var contract = Contracts.FirstOrDefault(c => c.Player == player);
        if (contract == null)
        {
            throw new InvalidOperationException("اللاعب مش موجود");
        }

        decimal refund = contract.CalculateSalary() / 2;
        Budget += refund;

        Players.Remove(player);
        Contracts.Remove(contract);
    }


    public static Club operator +(Club club1, Club club2)
    {
        var mergedClub = new Club($"{club1.Name} & {club2.Name}", club1.Budget + club2.Budget);
        mergedClub.Players.AddRange(club1.Players);
        mergedClub.Players.AddRange(club2.Players);
        mergedClub.Contracts.AddRange(club1.Contracts);
        mergedClub.Contracts.AddRange(club2.Contracts);
        return mergedClub;
    }
}