namespace Lab12;
using System.IO.Compression;

public class GKVFileManager
{
    public static void InspectDriver(string driverName)
        {
            Directory.CreateDirectory(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect");
            File.Create(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect\GKVDirInfo.txt").Close();
            var currentDrive = DriveInfo.GetDrives().Single(x => x.Name == driverName);

            using (StreamWriter file = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect\GKVDirInfo.txt"))
            {
                file.WriteLine("Список папок:");
                foreach (var s in currentDrive.RootDirectory.GetDirectories())
                {
                    file.WriteLine(s);
                }
                file.WriteLine("Список файлов:");
                foreach (var f in currentDrive.RootDirectory.GetFiles())
                {
                    file.WriteLine(f);
                }
            }

            File.Copy(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect\GKVDirInfo.txt", @"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVDirInfoCopy.txt", true);
            File.Delete(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect\GKVDirInfo.txt");
        }

        public static void CopyFiles(string path, string extention)
        {
            Directory.CreateDirectory(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVFiles");
            DirectoryInfo directory = new DirectoryInfo(path);
            DirectoryInfo directory2 = new DirectoryInfo(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect\GKVFiles\");
            foreach (var f in directory.GetFiles())
            {
                if (f.Extension == extention)
                    f.CopyTo(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVFiles\" + f.Name + extention, true);
            }
            if (!directory2.Exists)
                Directory.Move(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVFiles\", @"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect\GKVFiles\");
            else
                Directory.Delete(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVFiles\", true);
        }

        public static void CreateArchive(string dir)
        {
            string name = @"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect\GKVFiles";
            if (new DirectoryInfo(@"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVInspect").GetFiles("*.zip").Length == 0)
            {
                ZipFile.CreateFromDirectory(name, name + ".zip");
                DirectoryInfo direct = new DirectoryInfo(dir);
                foreach (var innerFile in direct.GetFiles())
                    innerFile.Delete();
                direct.Delete();
                ZipFile.ExtractToDirectory(name + ".zip", dir);
            }
        }
}