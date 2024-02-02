namespace ConsoleApp1.test
{
    public class Tests
    {

        [Test]
        public void EmployeeaddingnumbersMax()
        {
            // arrange
            var employee = new Employee("Mirek", "Gelda");

            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);

            // act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(7, result.Max);

        }

        [Test]
        public void EmployeeaddingnumbersMin()
        {
            // arrange
            var employee = new Employee("Mirek", "Gelda");

            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);

            // act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(3, result.Min);

        }
        [Test]
        public void EmployeeaddingnumbersAverage()
        {
            // arrange
            var employee = new Employee("Mirek", "Gelda");

            employee.AddGrade(5);
            employee.AddGrade(7);
            employee.AddGrade(3);

            // act
            var result = employee.GetStatistics();

            //assert
            Assert.AreEqual(5, result.Average);

        }
    }
}