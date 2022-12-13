namespace Lab14;

public static class Task4
{
    public static void FirstEvenThanOdd(int number)
    {
        object locker = new();
        Thread.Sleep(number * 1000 / 3);
        Thread firstThread = new Thread(ShowEvenNumbers!);
        Thread secondThread = new Thread(ShowOddNumbers!);

        firstThread.Start(number);
        secondThread.Start(number);


        void ShowEvenNumbers(object userNumber)
        {
            if (userNumber == null) throw new ArgumentNullException(nameof(userNumber));
            bool acquiredLock = false;
            try
            {
                Monitor.Enter(locker, ref acquiredLock);
                using var firstThreadStream = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_14\Lab14\Task4.txt", true);
                Console.WriteLine("\nЯ выполняю поток 1");
                for (var i = 1; i < (int)userNumber; i++)
                {
                    Thread.Sleep(100);
                    if (i % 2 == 0)
                    {
                        Console.Write($"{i} ");
                        firstThreadStream.Write($"{i} ");
                    }
                }

            }
            finally
            {
                if (acquiredLock)
                {
                    Monitor.Exit(locker);
                }
            }
        }

        void ShowOddNumbers(object anotherUserNumber)
        {
            bool acquiredLock = false;
            try
            {
                Console.WriteLine("\nЯ выполняю поток 2");
                Monitor.Enter(locker, ref acquiredLock);
                using var secondThreadStream = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_14\Lab14\Task4.txt", true);
                for (var i = 1; i < (int)anotherUserNumber; i++)
                {
                    Thread.Sleep(100);
                    if (i % 2 != 0)
                    {
                        Console.Write($"{i} ");
                        secondThreadStream.Write($"{i} ");
                    }
                }
            }
            finally
            {
                if (acquiredLock)
                {
                    Monitor.Exit(locker);
                }
            }
        }
    }

    public static void EvenOddChangingEveryTime(int number)
    {
        var mutex = new Mutex();
        Thread firstThread = new Thread(ShowEvenNumbers!);
        Thread secondThread = new Thread(ShowOddNumbers!);
        Thread.Sleep(number * 1000 / 2);

        firstThread.Start(number);
        secondThread.Start(number);

        void ShowEvenNumbers(object userNumber)
        {
            Console.WriteLine("\nЯ выполняю поток 3");
            for (var i = 0; i < (int)userNumber; i++)
            {
                mutex.WaitOne();
                Thread.Sleep(10);
                if (i % 2 == 0)
                {
                    Console.Write($"{i} ");
                }
                mutex.ReleaseMutex();
            }
        }

        void ShowOddNumbers(object anotherUserNumber)
        {
            Console.WriteLine("\nЯ выполняю поток 4");
            for (var i = 0; i < (int)anotherUserNumber; i++)
            {
                mutex.WaitOne();
                Thread.Sleep(10);
                if (i % 2 != 0)
                {
                    Console.Write($"{i} ");
                }
                mutex.ReleaseMutex();
            }

        }
    }
}