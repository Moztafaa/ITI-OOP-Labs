namespace Lab5;

public interface ISponsorable
{
    public string Sponsor { get; set; }
    public decimal SponsorshipAmount { get; set; }
    public decimal CalculateTotalEarnings(IContract contract);
}