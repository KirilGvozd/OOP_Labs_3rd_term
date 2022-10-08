using System.IO.Compression;
using System.Runtime.CompilerServices;

namespace Lab3;

public static class StatisticOperation
{
    public static int Sum (Stack givenStack)
    {
        int sumOfAllElements = 0;
        for (int i = 0; i < givenStack.StackCapacity; i++)
        {
            sumOfAllElements += givenStack.MyStack[i];
        }
        
        return sumOfAllElements;
    }

    public static int Difference (Stack givenStack)
    {
        int min = Int32.MaxValue;
        int max = Int32.MinValue;

        for (int i = 0; i < givenStack.StackCapacity; i++)
        {
            if (givenStack.MyStack[i] < min)
            {
                min = givenStack.MyStack[i];
            }

            if (givenStack.MyStack[i] > max)
            {
                max = givenStack.MyStack[i];
            }
        }

        return (max - min);
    }

    public static int CounterOfElements(Stack givenStack)
    {
        return givenStack.Counter;
    }

    public static int QuestionFinder(this string givenString)
    {
        int counterOfQuestions = 0;
        for (int i = 0; i < givenString.Length; i++)
        {
            if (givenString[i] == '?')
            {
                counterOfQuestions++;
            }
        }

        return counterOfQuestions;
    }

    public static bool CheckingFirstElement(this Stack givenStack)
    {
        if (givenStack.MyStack[0] == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}