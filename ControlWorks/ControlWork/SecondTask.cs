namespace ControlWork;

public class Task : IComparable, IPriority
{
    public int Number { get; set; }
    public int SecondNumber { get; set; }
    public int Priority { get; set; }

    public Task(int firstNumber, int secondNumber, int priority)
    {
        this.Number = firstNumber;
        this.SecondNumber = secondNumber;
        this.Priority = priority;
    }
    
    public int CompareTo(object? obj)
    {
        throw new NotImplementedException();
    }
    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public void Plus(int sum)
    {
        Priority += 2;
    }
    
}