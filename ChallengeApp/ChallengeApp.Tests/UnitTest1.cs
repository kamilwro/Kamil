using System.Reflection.Metadata;

namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenUserCollectedTwoScores_ShouldCorrectResult()
        {
            // arrange
            var user = new User("Kamil", "XZY", 20);
            user.addScore(6);
            user.addScore(7);

            // act
           var result = user.Result;

            // assert
            Assert.AreEqual(13, result);
        }
    }
}