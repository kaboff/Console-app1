
namespace ConsoleApp1.test
{
    public class TypeTest
    {
        [Test]
        public void Comparisonofnumbers()
        {
            // arrange
            int number1 = 25;
            int number2 = 25;
            // act


            //assert
            Assert.AreEqual(number1, number2);
        }
        [Test]
        public void Othercustomcheck()
        {
            // arrange
            var user1 = GetUser("Dima","lock",23);
            var user2 = GetUser("Dima","lock",21);
            // act


            //assert
            Assert.AreNotEqual(user1, user2);
        }
        [Test]
        public void checkingloginvalue()
        {
            // arrange
            var user1 = GetUser("Dima","lock",23);
            var user2 = GetUser("Dima","lock",21);
            // act


            //assert
            Assert.AreNotEqual(user1, user2);
        }

        private Employee GetUser(string name,string password,int age)
        {
            return new Employee ( name,password,age);
        }

    }

}
