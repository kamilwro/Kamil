using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ChallengeApp;



public class Employee 
{
    public List<float> grades = new List<float>();
    public Employee(string name, string surname) 
    {
        this.Name = name;
        this.Surname = surname;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }

    

    public void AddGrade(float grade) 
    {
        this.grades.Add(grade);
    }
     //publiczna metoda zwracająca obiekty ze statystykami
     
    public Statistics GetStatistics() 
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Max = float.MinValue;
        statistics.Min = float.MaxValue;

        foreach (var grade in this.grades)
        {
            statistics.Max = Math.Max(statistics.Max, grade);
            statistics.Min = Math.Min(statistics.Min, grade);
            statistics.Average += grade;
        }
        
        statistics.Average /= this.grades.Count;
        
        
        return statistics;
    }


}