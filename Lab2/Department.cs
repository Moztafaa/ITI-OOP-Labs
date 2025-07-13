namespace Lab2;

public class Department(string name, string location)
{
    public string Name { get; set; } = name;
    public string Location { get; set; } = location;
    public List<Doctor> Doctors { get; set; } = new();
    public List<MedicalEquipment> Equipment { get; set; } = new();

    public void AddDoctor(Doctor doctor)
    {
        if (!Doctors.Contains(doctor)) Doctors.Add(doctor);
    }

    public void AddEquipment(MedicalEquipment equipment)
    {
        Equipment.Add(equipment);
    }

    public override string ToString()
    {
        return $"{Name} Department (Location: {Location})";
    }
}