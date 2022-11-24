namespace Lab12;

public static class GKVFileInfo
{
    public static string? PrintFullPath(string nameOfTheFile)
    {
        var ourFile = new FileInfo(nameOfTheFile);
        return ourFile.FullName;
    }

    public static void PrintSizeExtensionAndName(string nameOfTheFile)
    {
        var ourFile = new FileInfo(nameOfTheFile);
        Console.WriteLine($"\nРазмер файла: {ourFile.Length} байт.");
        Console.WriteLine($"Расширение файла: {ourFile.Extension}");
        Console.WriteLine($"Имя файла: {ourFile.Name}");
    }

    public static void PrintDateOfCreation(string nameOfTheFile)
    {
        var ourFile = new FileInfo(nameOfTheFile);
        Console.WriteLine($"Дата создания: {ourFile.CreationTime}");
        Console.WriteLine($"Дата последнего изменения файла: {ourFile.LastWriteTime}");
    }
}