using ConsoleApp1;

var employee = new Employee("Mirek", "Gelda");
employee.AddGrade(5);
employee.AddGrade(7);
employee.AddGrade(3);
var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
