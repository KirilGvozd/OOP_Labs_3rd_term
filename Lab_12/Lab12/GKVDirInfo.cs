namespace Lab12;

public class GKVDirInfo
{
    public static int PrintNumberOfFiles(string nameOfTheDirectory)
    {
        var directory = new DirectoryInfo(nameOfTheDirectory);
        return directory.GetFiles().Length;
    }

    public static void TimeOfCreation(string nameOfTheDirectory)
    {
        var directory = new DirectoryInfo(nameOfTheDirectory);
        Console.WriteLine($"Время создания директория {nameOfTheDirectory}: {directory.CreationTime}");
    }
    
    public static int NumberOfSubDirectories(string nameOfTheDirectory)
    {
        var directory = new DirectoryInfo(nameOfTheDirectory);
        return directory.GetDirectories().Length;
    }

    public static void ListOfParentDirectories(string nameOfTheDirectory)
    {
        var directory = new DirectoryInfo(nameOfTheDirectory);
        Console.WriteLine($"Список родительских директориев: {directory.Parent}");
    }
}