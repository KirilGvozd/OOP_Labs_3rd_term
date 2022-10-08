using System.Diagnostics.CodeAnalysis;
using System.Net.Http.Headers;

namespace Lab3;

public class Lab3
{
    public static void Main()
    {
        Stack stack1 = new Stack(10);
        Stack stack2 = new Stack(10);
        stack1.Push(200);
        stack1.Push(300);
        Console.WriteLine("Element from the top of stack: " + stack1.TopElement());
        stack1.Pop();
        Console.WriteLine("Element from the top of stack: " + stack1.TopElement());
        stack1.Push(302);
        stack1.Push(201);

        stack1 = stack1 * 200;
        Console.WriteLine("Element from the top: " + stack1.TopElement());

        stack1 = stack1 / 200;
        Console.WriteLine("Element from the top: " + stack1.TopElement());

        if (stack1)
        {
            Console.WriteLine("There is an element below zero in your stack.");
        }
        else
        {
            Console.WriteLine("There is no elements below zero in your stack.");
        }

        if (stack1 == stack2)
        {
            Console.WriteLine("Stacks are the same.");
        }
        else
        {
            Console.WriteLine("Stacks are different.");
        }

        Stack.Production production = new Stack.Production("id Software");
        Console.WriteLine("Organisation name: " + production.Name);

        Stack.Developer developerKirill = new Stack.Developer("Kirill", production.Name);
        Console.WriteLine("Developer " + developerKirill.Name + " is working in the " + developerKirill.Department);

        Console.WriteLine("Sum of all elements in the first stack is " + StatisticOperation.Sum(stack1));
        Console.WriteLine("The difference between max and min elements in the first stack is " + StatisticOperation.Difference(stack1));
        Console.WriteLine("Number of elements in the second stack is " + StatisticOperation.CounterOfElements(stack2));

        string str = "If I would, could you?";
        Console.WriteLine("Number of questions in the given string: " + str.QuestionFinder());

        if (stack1.CheckingFirstElement())
        {
            Console.WriteLine("There is a zero element on top of your stack.");
        }
        else
        {
            Console.WriteLine("There is no zero element on top of your stack.");
        }
    }
}