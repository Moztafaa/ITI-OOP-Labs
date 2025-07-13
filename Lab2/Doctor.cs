namespace Lab2;

public class Doctor(string name, string doctorId, string specialization)
{
    public string Name { get; set; } = name;
    public string DoctorId { get; set; } = doctorId;
    public string Specialization { get; set; } = specialization;
    public List<Patient> Patients { get; set; } = new();
    public List<Appointment> Appointments { get; set; } = new();

    public override string ToString()
    {
        return $"Dr. {Name} ({DoctorId})";
    }
}