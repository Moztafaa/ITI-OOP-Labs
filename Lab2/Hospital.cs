namespace Lab2;

public class Hospital(string name, string address)
{
    public string Name { get; set; } = name;
    public string Address { get; set; } = address;
    public List<HospitalWing> Wings { get; } = new();
    public List<Department> Departments { get; set; } = new();

    public HospitalWing AddWing(string name, string description)
    {
        var wing = new HospitalWing(this, name, description);
        Wings.Add(wing);
        return wing;
    }

    public void AddDepartment(Department department)
    {
        Departments.Add(department);
    }

    public override string ToString()
    {
        return $"Hospital: {Name}";
    }

    public class HospitalWing(Hospital hospital, string name, string description)
    {
        public string Name { get; set; } = name;
        public string Description { get; set; } = description;
        private Hospital Hospital { get; } = hospital;

        public override string ToString()
        {
            return $"- {Name}: {Description}";
        }
    }
}