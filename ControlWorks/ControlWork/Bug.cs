namespace ControlWork;

public class Bug : Task, IPriority
{
    public Bug(int firstNumber, int secondNumber, int priority) : base(firstNumber, secondNumber, priority)
    {

    }

    public void Plus(int Sum)
    {
        Priority += 5;
    }
}