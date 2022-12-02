namespace Lab12;

public static class Lab12
{
    public static void Main()
    {
        try
        {
            Console.WriteLine($"Свободное место на диске D: {GKVDiskInfo.FreeDiskSpace("D")}");
            Console.WriteLine($"Формат диска D: {GKVDiskInfo.DiskFormat("D")}");
            GKVDiskInfo.InformationAboutDisk("D");
            GKVLog.WriteInLog("GKVDiskInfo.InformationAboutDisk()");


            Console.WriteLine($"\nПолный путь к файлу GKVlogfile.txt: {GKVFileInfo.PrintFullPath(@"GKVlogfile.txt")}");
            GKVFileInfo.PrintSizeExtensionAndName(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVlogfile.txt");
            GKVLog.WriteInLog("GKVDiskInfo.InformationAboutDisk()", "GKVlogfile.txt", @"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVlogfile.txt");
            GKVFileInfo.PrintDateOfCreation(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVLogFile.txt");
            Console.WriteLine($"\nКол-во файлов в директории Downloads: {GKVDirInfo.PrintNumberOfFiles(@"C:\Users\kiril\Downloads")}");
            GKVDirInfo.TimeOfCreation(@"D:\Semestr_3");
            Console.WriteLine($"Кол-во поддиректориев в директории Semestr_3: {GKVDirInfo.NumberOfSubDirectories(@"D:\Semestr_3")}");
            GKVDirInfo.ListOfParentDirectories(@"D:\Semestr_3\OOP_Labs\Lab_12");
            GKVFileManager.InspectDriver("D:\\");
            GKVFileManager.CopyFiles(@"C:\Users\kiril\Downloads", ".docx");
            GKVFileManager.CreateArchive(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\Archive");
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            throw;
        }
    }
}