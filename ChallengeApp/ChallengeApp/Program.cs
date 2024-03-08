using ChallengeApp;


var employee = new Employee("Kamil", "XYZ");

employee.AddGrade(29.5F);
employee.AddGrade(2);
employee.AddGrade(8);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N3}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");

