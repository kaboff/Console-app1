namespace ConsoleApp1
{
    public class User
    {
        private List<int> score = new List<int>();
        private object scores;

        public User(string name, string surname, string age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }
            public string name { get; private set; }
            public string surname { get; private set; }
            public string age { get; private set; }
    
            public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }

    }
}
