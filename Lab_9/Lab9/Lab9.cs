using System.Collections.ObjectModel;

namespace Lab9;

public static class Lab9
{
    public static void Main()
    {
        Set<Computer> storageOfObjects = new Set<Computer>();
        Computer firstComputer = new Computer("Nvidia GTX 1080Ti", "AMD Ryzen 3", 16, 512);
        Computer secondComputer = new Computer("AMD RX6900 XT", "AMD Threadripper", 64, 1024);
        storageOfObjects.Add(firstComputer);
        storageOfObjects.Add(secondComputer);
        storageOfObjects.Print();

        storageOfObjects.Remove(secondComputer);
        storageOfObjects.Print();
        
        storageOfObjects.FindItem(firstComputer);
        //storageOfObjects.FindItem(secondComputer);
        firstComputer.IsWorking();
        firstComputer.AddingRam(8);
        firstComputer.AddingStorage(512);
        Console.WriteLine(firstComputer);
        
        //2 задание
        HashSet<int> evenNumbers = new HashSet<int>();
        for (int i = 0; i < 6; i++)
        {
            evenNumbers.Add(i * 2);
        }

        foreach (var item in evenNumbers)
        {
            Console.Write($"{item} ");
        }

        for (int i = 0; i < 3; i++)
        {
            evenNumbers.Remove(10 - (i * 2));
        }

        Console.WriteLine("Удалены некоторые элементы:");
        foreach (var item in evenNumbers)
        {
            Console.Write($"{item} ");
        }

        evenNumbers.Add(100);
        Console.WriteLine("Добавлен элемент 100:");
        foreach (var item in evenNumbers)
        {
            Console.Write($"{item} ");
        }


        List<int> newCollection = new List<int>();
        foreach (var item in evenNumbers)
        {
            newCollection.Add(item);
        }

        Console.WriteLine("Это уже новая коллекция:");
        foreach (var item in newCollection)
        {
            Console.Write($"{item} ");
        }

        if (newCollection.Contains(100))
        {
            Console.WriteLine("Этот элемент есть в новой коллекции.\n");
        }
        else
        {
            Console.WriteLine("Этого элемента нет в новой коллекции.\n");
        }
        
        //3 задание
        var observing = new ObservableCollection<Computer>();
        observing.CollectionChanged += Computer.CollectionChanged;
        observing.Add(firstComputer);
        observing.Add(secondComputer);
        observing.Remove(firstComputer);
    }
}