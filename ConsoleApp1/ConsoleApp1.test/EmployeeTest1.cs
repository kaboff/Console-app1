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

        
    }
}