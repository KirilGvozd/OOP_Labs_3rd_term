namespace Lab6;

public class NameException : Exception
{
    private string ErrorInName { get; set; }
    public string Name { get; private set; }

    public NameException(string message, string name) : base(message)
    {
        Name = name;
    }
}