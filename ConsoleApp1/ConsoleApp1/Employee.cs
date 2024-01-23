namespace ConsoleApp1;

public class Employee
{
    private List<int> point = new List<int>();
    public Employee(string name, string lastname, int age)
    {
        this.Name = name;
        this.Lastname = lastname;
        this.Age = age;
    }
    public string Name { get; set; }
    public string Lastname { get; set; }
    public int Age { get; set; }
    public int Result
    {
        get
        {
                return this.point.Sum();
        }
    }
    public void AddScore(int number)
    {
            this.point.Add(number);
     }
}