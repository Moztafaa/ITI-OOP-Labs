namespace Lab7;

public class Coach(string licenseLevel, string tacticalFormation, string name, int age)
    : Person(name, age), IStaff
{
    public string LicenseLevel { get; set; } = licenseLevel;
    public string TacticalFormation { get; set; } = tacticalFormation;

    public override string DisplayInfo()
    {
        return $"Coach License level: {LicenseLevel}\n Name: {Name}\n Age: {Age}\n TacticalFormation: {TacticalFormation}";
    }

    public string GetRole()
    {
        return $"His role is Coach";
    }

    public override string ToString()
    {
        return $"He is {typeof(Player)}";
    }
}
