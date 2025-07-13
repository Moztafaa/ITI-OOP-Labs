namespace Lab2;

public class Appointment
{
    public Appointment(Patient patient, Doctor doctor, DateTime date, string description)
    {
        Patient = patient;
        Doctor = doctor;
        AppointmentDate = date;
        Description = description;

        patient.Appointments.Add(this);
        doctor.Appointments.Add(this);
    }

    public DateTime AppointmentDate { get; set; }
    public string Description { get; set; }
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }

    public override string ToString()
    {
        return $"With {Doctor.Name} on {AppointmentDate.ToShortDateString()}: {Description}";
    }
}