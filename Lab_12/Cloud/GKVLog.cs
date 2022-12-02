namespace Lab12;

public class GKVLog
{
    private static StreamWriter? _logfile;
    private static readonly string PathLog = @"D:\Semestr_3\OOP_Labs\Lab_12\Lab12\GKVlogfile.txt";
    public static void WriteInLogFile(string action, string fileName = "", string path = "")
    {
        if (fileName.Length != 0 && path.Length != 0)
        {
            using (_logfile = new StreamWriter(PathLog, true))
            {
                _logfile.WriteLine($"{DateTime.Now.ToString()}");
                _logfile.WriteLine($"Действие: {action}");
                _logfile.WriteLine($"Имя файла: {fileName}");
                _logfile.WriteLine($"Путь к файлу: {path}");
            }
        }
        else
        {
            using (_logfile = new StreamWriter(PathLog, true))
            {
                _logfile.WriteLine($"{DateTime.Now.ToString()}");
                _logfile.WriteLine($"Действие: {action}");
            }
        }
    }
}