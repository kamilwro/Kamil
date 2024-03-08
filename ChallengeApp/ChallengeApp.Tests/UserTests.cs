using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void CheckingMethodGetStatisticMin()
        {
            // arrange
            var employee = new Employee("Kamil", "XZY");
            employee.AddGrade(6);
            employee.AddGrade(7);
            

            // act
            var statistics = employee.GetStatistics();

            // assert
            Assert.AreEqual(6, statistics.Min);
        }
        [Test]
        public void CheckingMethodGetStatisticMax()
        {
            // arrange
            var employee = new Employee("Kamil", "XZY");
            employee.AddGrade(50);
            employee.AddGrade(7);
            employee.AddGrade(15);

            // act
            var statistic = employee.GetStatistics();

            // assert
            Assert.AreEqual(50, statistic.Max);
        }
        [Test]
        public void CheckingMethodGetStatisticAverage()
        {
            // arrange
            var employee = new Employee("Kamil", "XZY");
            employee.AddGrade(9);
            employee.AddGrade(7);
            employee.AddGrade(-16);
            

            // act
            var statistic = employee.GetStatistics();

            // assert
            Assert.AreEqual(0, statistic.Average);
        }
    }
}