namespace Lab2;

public class Patient(string name, int patientId, string medicalHistory = "") : object
{
    public string Name { get; set; } = name;

    public int PatientId { get; set; } = patientId;
    public string MedicalHistory { get; set; } = medicalHistory;
    public List<Doctor> Doctors { get; set; } = new();
    public List<Appointment> Appointments { get; set; } = new();

    public override string ToString()
    {
        return $"Patient: {Name} (ID: {PatientId})";
    }

    public void AddDoctor(Doctor doctor)
    {
        if (doctor is not null && !Doctors.Contains(doctor))
        {
            Doctors.Add(doctor);
            doctor.Patients.Add(this);
        }
    }
}