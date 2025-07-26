namespace Lab7;

public class MedicalStaff(string specialization, string name, int age) : Person(name, age), IStaff
{
    public string Specialization { get; set; } = specialization;

    public override string DisplayInfo()
    {
        return $"MedicalStaff member NaSpecialization in {Specialization}\n Name: {Name}";
    }

    public string GetRole()
    {
        return $"His role is MedicalStaff";
    }

}
