namespace ConsoleApp1.test
{
    public class Tests
    {

        [Test]
        public void Additionofpositivenumbers()
        {
            // arrange
            var employee = new Employee("Mirek", "Gielda", 19);
            employee.AddScore(5);
            employee.AddScore(6);
            employee.AddScore(3);
            // act
            var result = employee.Result;

            //assert
            Assert.AreEqual(14, result);
        }

        [Test]
        public void AAddingnegativenumbers()
        {
            // arrange
            var employee2 = new Employee("Sonia", "Gielda", 23);
            employee2.AddScore(-5);
            employee2.AddScore(-6);
            employee2.AddScore(-3);

            // act
            var result = employee2.Result;

            //assert
            Assert.AreEqual(-14, result);


        }

        [Test]
        public void Additionofmixednumbers()
        {
            // arrange
            var employee3 = new Employee("Marek", "Gielda", 25);
            employee3.AddScore(5);
            employee3.AddScore(-6);
            employee3.AddScore(-3);

            // act
            var result = employee3.Result;

            //assert
            Assert.AreEqual(-4, result);

        }
    }
}