namespace Lab2;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("---Association---");

        var patient1 = new Patient("John Smith", 1001);
        var doctor1 = new Doctor("Alice Jones", "Cardiology", "2001");

        patient1.AddDoctor(doctor1);

        var appointment1 = new Appointment(patient1, doctor1, new DateTime(2025, 1, 1), "Headache");

        Console.WriteLine(patient1);
        Console.WriteLine("\nAttending Doctors:");
        foreach (var doctor in patient1.Doctors) Console.WriteLine($"- {doctor}");

        Console.WriteLine("\nAppointments for John Smith:");
        foreach (var appt in patient1.Appointments) Console.WriteLine($"- {appt}");

        Console.WriteLine("---Aggregation---");

        var cardiologyDept = new Department("Cardiology", "Floor 3");
        var ekgMachine = new MedicalEquipment("EKG Machine", "EKG-1001", DateTime.Now.AddMonths(6));

        cardiologyDept.AddDoctor(doctor1);
        cardiologyDept.AddEquipment(ekgMachine);

        var doctor2 = new Doctor("Michael Brown", "Neurology", "2002");

        Console.WriteLine(cardiologyDept);
        Console.WriteLine("\nDoctors:");
        foreach (var doctor in cardiologyDept.Doctors) Console.WriteLine($"- {doctor}");

        Console.WriteLine("\nEquipment:");
        foreach (var equipment in cardiologyDept.Equipment) Console.WriteLine($"- {equipment}");

        Console.WriteLine("---Composition---");

        var cityHospital = new Hospital("City General Hospital", "123 Main St");
        cityHospital.AddWing("North Wing", "General Wards");
        cityHospital.AddWing("East Wing", "Emergency Services");

        cityHospital.AddDepartment(cardiologyDept);

        Console.WriteLine(cityHospital);
        Console.WriteLine("Wings:");
        foreach (var wing in cityHospital.Wings) Console.WriteLine(wing);
    }
}