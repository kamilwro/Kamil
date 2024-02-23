namespace ChallengeApp.TypeTests
{
    public class TypeTests
    {
        [Test]
        public void DigitComparison()
        {
            // arrange
            int digit1 = 60;
            int digit2 = 60;

            // act

            // assert
            Assert.AreEqual(digit1, digit2);
        }
        [Test]
        public void DigitNotComparison()
        {
            // arrange
            int digit1 = 60;
            int digit2 = -60;

            // act

            // assert
            Assert.AreNotEqual(digit1, digit2);
        }
        [Test]
        public void FloatingPointComparison()
        {
            // arrange
            float digit1 = 2.34F;
            float digit2 = 2.34F;

            // act

            // assert
            Assert.AreEqual(digit1, digit2);
        }
        [Test]
        public void StringComparis_UserAreDifferent()
        {
            // arrange

            string user1 = "Kamil";
            string user2 = "Adam";

            // act         

            // assert
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void Test()
        {
            // arrange

            var user1 = GetUser("Kamil", "XZY", 20);
            var user2 = GetUser("Kamil", "XZY", 20);

            // act

            // assert
            Assert.AreNotEqual(user1, user2);
        }
        private Employee GetUser(string name, string surname, int age)
        {
            return new Employee(name, surname, age);
        }
    }

}

    
