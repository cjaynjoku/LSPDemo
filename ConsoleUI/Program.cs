// See https://aka.ms/new-console-template for more information
using DemoLibrary;

Manager accountingVP = new Manager();

accountingVP.FirstName = "Emma";
accountingVP.LastName = "Corey";
accountingVP.CalculatePerHourRate(4);
Employee emp = new Employee();

emp.FirstName = "Some";
emp.LastName = "Boytrip";
emp.AssignManager(accountingVP);
emp.CalculatePerHourRate(2);

Console.WriteLine($" { emp.FirstName }'s salary is $ { emp.Salary }/ hour.");
Console.ReadLine();