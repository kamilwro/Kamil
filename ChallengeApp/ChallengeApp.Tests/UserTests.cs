using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectedTwoScores_ShouldCorrectResult()
        {
            // arrange
            var user = new Employee("Kamil", "XZY", 20);
            user.AddScore(6);
            user.AddScore(7);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(13, result);
        }
        [Test]
        public void WhenUserCollectedTreeScores_ShouldCorrectResult()
        {
            // arrange
            var user = new Employee("Micha³", "XCY", 30);
            user.AddScore(9);
            user.AddScore(7);
            user.AddScore(-16);

            // act
            var result = user.Result;

            // assert
            Assert.AreEqual(0, result);
        }
    }
}