using ConsoleApp1;

var employee1 = new Employee("Mirek", "Gielda", 19);
var employee2 = new Employee("Sonia", "Gielda", 23);
var employee3 = new Employee("Marek", "Gielda", 25);

employee1.AddScore(7);
employee1.AddScore(7);
employee1.AddScore(7);
employee1.AddScore(7);
employee1.AddScore(8);

employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(5);
employee2.AddScore(6);

employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(3);
employee3.AddScore(4);

List<Employee> employees = new List<Employee>()
{
    employee1,employee2, employee3
};


int maxResult = -1;
Employee employeeWitchMaxResult = null;


foreach (var employee in employees)
{
    if (employee.Result >= maxResult)
    {
        maxResult = employee.Result;
        employeeWitchMaxResult = employee;
    }
    
}

Console.WriteLine(employeeWitchMaxResult.Name +  employeeWitchMaxResult.Lastname +
   + employeeWitchMaxResult.Age + maxResult );