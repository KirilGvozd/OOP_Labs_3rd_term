using System.Diagnostics;
using System.Threading;

namespace Lab14;

public static class Lab14
{
    [Obsolete("Obsolete")]
    public static void Main()
    {
        // 1 задание
        var allProcesses = Process.GetProcesses();
        foreach (var process in allProcesses)
        {
            try
            {
                Console.WriteLine(
                    $"Id процесса: {process.Id}, Имя процесса: {process.ProcessName}, Приоритет процесса: " +
                    $"{process.BasePriority}, Время запуска: {process.StartTime}, " +
                    $"Объём виртуальной памяти для процесса в байтах: {process.VirtualMemorySize64}, Всего времени использовал процесс: {process.TotalProcessorTime}.");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //2 задание
        var domain = AppDomain.CurrentDomain;
        Console.WriteLine($"\nИмя домена: {domain.FriendlyName}\nДетали конфигурации: {domain.SetupInformation}\n");
        var currentBuilds = AppDomain.CurrentDomain.GetAssemblies();
        Console.WriteLine("Все сборки в текущем домене:");
        foreach (var build in currentBuilds)
        {
            Console.WriteLine(build.GetName().Name);
        }

        try
        {
            AppDomain newDomain = AppDomain.CreateDomain("New domain");
            newDomain.Load(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\obj\Debug\net6.0\Lab13.dll");
            AppDomain.Unload(newDomain);

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        //3 задание
        var newThread = new Thread(ThreadInfo!);
        newThread.Start(Thread.CurrentThread);
        Thread.Sleep(5000);
        Console.Write("Введите число n: ");
        var userInput = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"\nПростые числа от 1 до {userInput}:");
        using var newStream = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_14\Lab14\Task3.txt", false);
        for (int i = 2; i < userInput; i++)
        {
            if (IsPrime(i))
            {
                Console.Write($"{i} ");
                newStream.Write($"{i} ");
            }
        }
        
        //4 задание
        
        Console.WriteLine("\nСначала чётные, потом нечётные:");
        Task4.FirstEvenThanOdd(userInput);
        Console.WriteLine("\nПоочерёдно чётные и нечётные:");
        Task4.EvenOddChangingEveryTime(userInput);
        
        //5 задание
        int num = 5;
        TimerCallback tm = new TimerCallback(Multiplier!);
        Timer timer = new Timer(tm, num, 0, 100);
        Thread.Sleep(6000);

    }

    private static bool IsPrime(int number)
    {
        for (var i = 2; i < number; i++) 
        { 
            if (number % i == 0) 
                return false; 
        } 
        return true; 
    }

    private static void ThreadInfo(object thread)
    {
        var currentThread = thread as Thread;
        Console.WriteLine($"\nИмя потока: {currentThread!.Name}");
        Console.WriteLine($"Статус потока: {currentThread.ThreadState}");
        Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
        Console.WriteLine($"Числовой идентификатор потока: {currentThread.ManagedThreadId}");
    }

    private static void Multiplier(object obj)
    {
        int limit = (int)obj;
        for (int i = 0; i < limit; i++)
        {
            Console.WriteLine($"{i} * {i +1} = {i * (i + 1)}");
        }
    }

}