
internal class User
{
    private string v1;
    private string v2;

    public User(string v1, string v2, int v)
    {
        this.v1 = v1;
        this.v2 = v2;
    }

    public static int Result { get; internal set; }
    public string Surname { get; internal set; }
    public string Age { get; internal set; }
    public string Name { get; internal set; }

    internal void Addscore(int v)
    {
        throw new NotImplementedException();
    }

    internal void AddScore(int v)
    {
        throw new NotImplementedException();
    }

    public static implicit operator User(int v)
    {
        throw new NotImplementedException();
    }
}