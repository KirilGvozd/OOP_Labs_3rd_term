using System.Collections.Concurrent;
using System.Diagnostics;
using System.Numerics;

namespace Lab15;

public static class Lab15
    {
        public static void Main()
        {
            //1 задание
            var task = new Task<int>(MandelbrotSet);
            
            Console.WriteLine($"Номер задачи: {task.Id}\nСтатус: {task.Status}");

            var stopwatch = new Stopwatch();
            task.Start();
            stopwatch.Start();
            Console.WriteLine($"Номер задачи: {task.Id}\nСтатус: {task.Status}");
            task.Wait();
            stopwatch.Stop();
            Console.WriteLine($"Номер задачи: {task.Id}\nСтатус: {task.Status}");
            Console.WriteLine($"Время выполнения задачи в миллисекундах: {stopwatch.ElapsedMilliseconds} ");
            Console.WriteLine($"Кол-во итераций подсчета элементов: {task.Result}");

            
            //2 задание
            var cancellationToken = new CancellationTokenSource();

            Task second = Task.Factory.StartNew(MandelbrotSetWithCancellation!, cancellationToken.Token, cancellationToken.Token);
            try
            {
                cancellationToken.Cancel();
                second.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine($"Задача остановлена. Текст ошибки: {e.Message}");
            }

            
            //3 задание
            var firstSquare = new Task<double>(() => Math.Pow(2, 2));
            var secondSquare = new Task<double>(() => Math.Pow(3, 2));
            var thirdSquare = new Task<double>(() => Math.Pow(4, 2));

            firstSquare.Start();
            secondSquare.Start();
            thirdSquare.Start();
            thirdSquare.Wait();
            firstSquare.Wait();
            secondSquare.Wait();

            var overallSquare = new Task<double>(() => firstSquare.Result + secondSquare.Result + thirdSquare.Result);
            overallSquare.Start();
            Console.WriteLine($"Сумма площадей квадратов: {overallSquare.Result}\n");

            
            //4 задание
            var firstTask = new Task(() => Console.Write("Выполняется первое задание..."));
            var continueWithTask = firstTask.ContinueWith(s => Console.Write("Теперь второе задание."));
            firstTask.Start();

            var firstTaskForAwaiter = new Task(() => Console.Write("\nВыполняется первое задание с GetAwaiter..."));

            var secondTaskForAwaiter = firstTaskForAwaiter.GetAwaiter();
            secondTaskForAwaiter.OnCompleted(() =>
            {
                secondTaskForAwaiter.GetResult();
                Console.Write("Теперь второе.\n");
            });
            firstTaskForAwaiter.Start();
            firstTaskForAwaiter.Wait();

            //5 задание
            var array1 = new int[10000000];
            var array2 = new int[10000000];
            var array3 = new int[10000000];

            var stopwatchForFifthTask = new Stopwatch();

            stopwatchForFifthTask.Start();
            Parallel.For(0, 10000000, CreatingArrayElements);
            stopwatchForFifthTask.Stop();
            Console.WriteLine($"Время выполнения распараллеленного for: {stopwatchForFifthTask.ElapsedMilliseconds} мс");

            stopwatchForFifthTask.Restart();
            
            for (var i = 0; i < 10000000; i++)
            {
                array1[i] = 1;
                array2[i] = 1;
                array3[i] = 1;
            }

            stopwatchForFifthTask.Stop();
            Console.WriteLine($"Время выполнения обычного for: {stopwatchForFifthTask.ElapsedMilliseconds} мс");


            stopwatchForFifthTask.Restart();
            Parallel.ForEach(array1, SumOfElements);
            stopwatchForFifthTask.Stop();
            Console.WriteLine($"Время выполнения распараллеленного foreach {stopwatchForFifthTask.ElapsedMilliseconds} мс");

            stopwatchForFifthTask.Restart();
            
            foreach (int item in array1)
            {
            }

            stopwatchForFifthTask.Stop();
            Console.WriteLine($"Время выполнения обычного foreach в миллисекундах: {stopwatchForFifthTask.ElapsedMilliseconds}");

            void CreatingArrayElements(int x)
            {
                array1[x] = 2;
                array2[x] = 2;
                array3[x] = 2;
            }

            void SumOfElements(int item)
            {
            }

            //6 задание
            var firstArray = new int[10000000];
            var secondArray = new int[10000000];
            var thirdArray = new int[10000000];


            Parallel.Invoke
            (
                
                () =>
                {
                    for (var i = 0; i < firstArray.Length; i++)
                    {
                        firstArray[i] = i;
                    }
                },
                
                () =>
                {
                    for (var i = 0; i < secondArray.Length; i++)
                    {
                        secondArray[i] = i;
                    }
                },
                
                () =>
                {
                    for (var i = 0; i < thirdArray.Length; i++)
                    {
                        thirdArray[i] = i;
                    }
                }
            );

            //7 задание
            Console.WriteLine();
            BlockingCollection<string> blockingCollection = new BlockingCollection<string>(5);

            var sellers = new[]
            {
                
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(100);
                        blockingCollection.Add("Микроволновка");
                    }
                }),
                
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(200);
                        blockingCollection.Add("Миксер");
                    }
                }),
                
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(300);
                        blockingCollection.Add("Стиралька");
                    }
                }),
                
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(400);
                        blockingCollection.Add("Микроволновка");
                    }
                }),
                
                new Task(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(500);
                        blockingCollection.Add("Пылесос");
                    }
                })
            };

            foreach (var i in sellers)
            {
                if (i.Status != TaskStatus.Running)
                    i.Start();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Количество товара на складе: {blockingCollection.Count}");
                Thread.Sleep(600);
                Thread thr = new Thread(Client);
                thr.Start();
            }

            void Client()
            {
                
                if (blockingCollection.Count == 0)
                {
                    Console.WriteLine("Посетитель ничего не купил");
                    return;
                }
                
                Console.WriteLine($"Посетитель купил {blockingCollection.Take()}");
            }

            //8 задание
            Thread.Sleep(500);
            Console.WriteLine();
            int Fibonacci(int n)
            {
                if (n == 0 || n == 1)
                {
                    return n;
                }
                
                Thread.Sleep(500);
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            async void FibonacciAsync(int n)
            {
                Console.WriteLine($"Начат подсчет {n}-го числа Фибоначчи");
                var result = Task<int>.Factory.StartNew(() => Fibonacci(n));
                int value = await result;
                Console.WriteLine($"Результат: {value}");
            }

            FibonacciAsync(7);
            Console.ReadKey();
        }
     
        private static int MandelbrotSet()
        {
            int xMax = 800, yMax = 800;
            int maxIterations = 500;
            Complex zk = new Complex(0, 0);
            int count = 0;
            for (double y = 0; y < yMax; y += 0.1)
                for (double x = 0; x < xMax; x += 0.1)
                {
                    Complex c = new Complex(x, y);
                    int k = 0;
                    do
                    {
                        zk = Complex.Pow(zk, 2) + c;
                        k++;
                        count++;
                    } while ((zk.Magnitude <= 2.0) && (k < maxIterations));
                }
            
            return count;
        }
        private static int MandelbrotSetWithCancellation(object obj)
        {
            int xMax = 100, yMax = 200;
            int maxIterations = 200;
            var token = (CancellationToken)obj;
            var zk = new Complex(0, 0);
            int count = 0;
            for (double y = 0; y < yMax; y += 0.1)
                for (double x = 0; x < xMax; x += 0.1)
                {
                    var c = new Complex(x, y);
                    int k = 0;
                    do
                    {
                        if (token.IsCancellationRequested)
                        {
                            Console.WriteLine("Запрос отмены");
                            token.ThrowIfCancellationRequested();
                            return 0;
                        }
                        zk = Complex.Pow(zk, 2) + c;
                        k++;
                        count++;
                    } while ((zk.Magnitude <= 2.0) && (k < maxIterations));
                }

            return count;
        }
    }