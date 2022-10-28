namespace ControlWork;

public class FirstTask
{
    public static void Main()
    {
        //Первое задание A)
        string userInput = Console.ReadLine();
        string newString = userInput.Replace('s', '$');
        Console.WriteLine(newString);
        //Первое задание Б)
        int[,] array = new int[2,3]{ { 1, 2, 3 }, { 4, 5, 6 } };
        int sum1 = 0;
        for (int i = 0; i < 3; i++)
        {
            sum1 += array[0, i];
        }

        int sum2 = 0;
        for (int i = 0; i < 3; i++)
        {
            sum2 += array[1, i];
        }
        Console.WriteLine($"Сумма первого:{sum1} и сумма второго:{sum2}");
        
        //Второе задание
        Task firstObject = new Task(1, 2, 3);
        Task secondObject = new Task(1, 2, 3);
        bool equals = firstObject.Equals(secondObject);
        if (equals)
        {
            Console.WriteLine("Объекты равны");
        }
        else
        {
            Console.WriteLine("Объекты не равны");
        }
    }
}