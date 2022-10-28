namespace Lab6;

public class Logger
{
    public static void SwitchBetweenFileAndConsole(Exception e, bool fileFlag = true)
    {
        if (fileFlag)
            FileLogger(e);
        else
            ConsoleLogger(e);
    }
    private static void FileLogger(Exception e)
    {
        using var stream = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_6\Lab6\Log.txt", true);
        stream.WriteLine(DateTime.Now);
        stream.WriteLine("Тип: " + e.GetType());
        stream.WriteLine("INFO: " + e.Message);
    }
    private static void ConsoleLogger(Exception e)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Тип: " + e.GetType());
        Console.WriteLine("INFO: " + e.Message);
    }
}