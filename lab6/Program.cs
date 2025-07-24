using System;
using System.Collections.Generic;
using lab6;

class Program
{
    static int idCounter = 1;
    static int GenerateId() => idCounter++;

    static void Main()
    {
        // Create Department
        var employees = new List<Employee>();
        var departmentCode = "HR-2023";
        decimal initialBudget = 1022000m;
        var department = new Department( initialBudget);

        // Create Employees
        var fullTime = new FullTimeEmployee(GenerateId(), "John Doe", 6000m, DateTime.Now.AddYears(-3));
        var partTime = new PartTimeEmployee(GenerateId(), "Jane Smith", 0m, DateTime.Now.AddYears(-1), 100, 20m);

        // === Method Overloading ===
        Console.WriteLine($"Department Code: {departmentCode}\n");
        Console.WriteLine("=== Method Overloading ===");
        Console.WriteLine($"Regular Salary: {fullTime.CalculateSalary():C2}");
        Console.WriteLine($"With Performance Factor: {fullTime.CalculateSalary(1.2m):C2}\n");

        // === Multiple Inheritance ===
        Console.WriteLine("=== Multiple Inheritance ===");
        Console.WriteLine($"Promotion Eligible: {partTime.IsEligibleForPromotion()}");
        Console.WriteLine();

        // Add employees to department
        // (Assume AddEmployee is not implemented, so add to list directly for demo)
        employees.Add(fullTime);
        employees.Add(partTime);

        // === Payroll ===
        Console.WriteLine($"=== {departmentCode} Payroll ===");
        Console.WriteLine($"{fullTime.Name}: {fullTime.CalculateSalary():C2}");
        Console.WriteLine($"  + Bonus: {fullTime.CalculateBonus():C2}");
        Console.WriteLine($"{partTime.Name}: {partTime.CalculateSalary():C2}");
        Console.WriteLine();

        // Remaining Budget (simulate salary and bonus deduction)
        decimal totalPaid = fullTime.CalculateSalary() + fullTime.CalculateBonus() + partTime.CalculateSalary();
        decimal remainingBudget = initialBudget - totalPaid;
        Console.WriteLine($"Remaining Budget: {remainingBudget:C2}");
    }
}
