namespace Lab3;

public class Lab3
{
    public static void Main()
    {
        Stack stack1 = new Stack(10);
        stack1.Push(200);
        stack1.Push(300);
        Console.WriteLine("Element from the top of stack: " + stack1.TopElement());
        stack1.Pop();
        Console.WriteLine("Element from the top of stack: " + stack1.TopElement());
    }
}