namespace Lab12;

public static class Lab12
{
    public static void Main()
    {
        GKVLog.WriteInLogFile("SomeAction()", "GKVlogfile.txt", @"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVlogfile.txt");
        Console.WriteLine($"Свободное место на диске D: {GKVDiskInfo.FreeDiskSpace("D")}");
        Console.WriteLine($"Формат диска D: {GKVDiskInfo.DiskFormat("D")}");
        GKVDiskInfo.InformationAboutDisk("D");

        Console.WriteLine($"\nПолный путь к файлу GKVlogfile.txt: {GKVFileInfo.PrintFullPath(@"GKVlogfile.txt")}");
        GKVFileInfo.PrintSizeExtensionAndName(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVlogfile.txt");
        GKVFileInfo.PrintDateOfCreation(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVlogfile.txt");
        Console.WriteLine($"\nКол-во файлов в директории Downloads: {GKVDirInfo.PrintNumberOfFiles(@"C:\Users\kiril\Downloads")}");
        GKVDirInfo.TimeOfCreation(@"D:\Semestr_3");
        Console.WriteLine($"Кол-во поддиректориев в директории Semestr_3: {GKVDirInfo.NumberOfSubDirectories(@"D:\Semestr_3")}");
        GKVDirInfo.ListOfParentDirectories(@"D:\Semestr_3\OOP_Labs\Lab_12");
    }
}