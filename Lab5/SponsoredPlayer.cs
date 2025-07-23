using System.Net.NetworkInformation;

namespace Lab5;

public class SponsoredPlayer(
    string name,
    int age,
    string position,
    double rating,
    string sponsor,
    decimal sponsorshipAmount,
    string sponsorName,
    decimal annualAmount)
    : Player(name, age, position, rating), ISponsorable
{
    public string Sponsor { get; set; } = sponsor;
    public decimal SponsorshipAmount { get; set; } = sponsorshipAmount;
    public string SponsorName { get; set; } = sponsorName;
    public decimal AnnualAmount { get; set; } = annualAmount;

    public decimal CalculateTotalEarnings(IContract contract)
    {
        return contract.CalculateSalary() + SponsorshipAmount;
    }
}