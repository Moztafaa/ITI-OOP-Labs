namespace Lab2;

public class MedicalEquipment(string name, string serialNumber, DateTime maintenanceDate)
{
    public string Name { get; set; } = name;
    public string SerialNumber { get; set; } = serialNumber;
    public DateTime MaintenanceDate { get; set; } = maintenanceDate;

    public override string ToString()
    {
        return $"{Name} (Serial: {SerialNumber})";
    }
}