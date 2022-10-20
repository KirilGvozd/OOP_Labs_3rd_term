namespace Lab5;
using System.IO;
using Newtonsoft.Json;

public class LibraryController
{
    public static List<PrintPublication> PrintBooks(Library library, int year)
    {
        return library.ListOfAllBooks.FindAll(item => item.YearOfPublication >= year);
    }

    public static void TextReader(Library item)
    {
        StreamReader file = new StreamReader("D://Semestr_3//OOP_Labs//Lab_5//Lab5.txt");
        while (file.ReadLine() is string line)
        {
            switch (line)
            {
                case "Book":
                    item.AddItem(new Book("Soft", "Mother", "Maxim", "Gorkiy", 150, 1905, 10));
                    break;
                case "Magazine":
                    item.AddItem(new Magazine("Discovery", "Disney LLC", 100, 2021));
                    break;
                case "WorkBook":
                    item.AddItem(new WorkBook(11, "Physics", "Physics 9 class", 80, 2015));
                    break;
                default:
                    break;
            }
        }
    }

    public static void JsonWriter(Library library)
    {
        var settings = new JsonSerializerSettings()
        {
            TypeNameHandling = TypeNameHandling.All,
        };
        using var stream = new StreamReader(@"D:\Semestr_3\OOP_Labs\Lab_5\Lab5.json");
        string jsonData = stream.ReadToEnd();

        List<PrintPublication> deserializedList = JsonConvert.DeserializeObject<List<PrintPublication>>(jsonData, settings);
        foreach (var item in deserializedList)
        {
            library.AddItem(item);
        }
    }
}