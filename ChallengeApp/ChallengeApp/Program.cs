using System;
using System.Runtime.Intrinsics.X86;

using ChallengeApp;


Employee user1 = new Employee("Kamil", "XZY", 20);
Employee user2 = new Employee("Michał", "XCY", 30);
Employee user3 = new Employee("Ala", "XDY", 40);


Console.WriteLine(user1.Name);
user1.AddScore(10);
user1.AddScore(8);
user1.AddScore(6);
user1.AddScore(4);
user1.AddScore(2);

var result1 = user1.Result;
Console.WriteLine(result1);

Console.WriteLine(user2.Name);
user2.AddScore(8);
user2.AddScore(6);
user2.AddScore(4);
user2.AddScore(2);
user2.AddScore(1);

var result2 = user2.Result;
Console.WriteLine(result2);

Console.WriteLine(user3.Name);
user3.AddScore(8);
user3.AddScore(6);
user3.AddScore(4);
user3.AddScore(9);
user3.AddScore(9);

var result3 = user3.Result;
Console.WriteLine(result3);


List<Employee> Employees = new List<Employee> { user1, user2, user3 };

int maxResult = 0;
Employee EmployeeWithMaxResult = null;

foreach (var employee in Employees)
{
    if (employee.Result > maxResult)
    {
        EmployeeWithMaxResult = employee;
        maxResult = employee.Result;

    }



}

Console.WriteLine("MaxResult");
Console.WriteLine(maxResult);
