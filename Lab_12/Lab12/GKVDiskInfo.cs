namespace Lab12;

public class GKVDiskInfo
{
    public static long FreeDiskSpace(string diskName)
    {
        var ourDrive = new DriveInfo(diskName);
        return ourDrive.AvailableFreeSpace;
    }

    public static string DiskFormat(string diskName)
    {
        var ourDrive = new DriveInfo(diskName);
        return ourDrive.DriveFormat;
    }

    public static void InformationAboutDisk(string diskName)
    {
        var ourDrive = new DriveInfo(diskName);
        Console.WriteLine($"\nИмя диска: {ourDrive.Name}");
        Console.WriteLine($"Объём диска: {ourDrive.TotalSize}");
        Console.WriteLine($"Доступный объём: {ourDrive.AvailableFreeSpace}");
        Console.WriteLine($"Метка тома: {ourDrive.VolumeLabel}");
    }
}