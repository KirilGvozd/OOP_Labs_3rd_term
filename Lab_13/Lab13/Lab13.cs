using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text.Json;


namespace Lab13;

public static class Lab13
{
    public static void Main()
    {
        //Binary-формат
        Book firstBook = new Book("Soft", "War and Peace", 1500, 1865);
        BinaryFormatter formatter = new BinaryFormatter();
        
        using (FileStream newStream = new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Binary.dat", FileMode.OpenOrCreate))
        {
            formatter.Serialize(newStream, firstBook);
        }

        using (FileStream secondStream = new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Binary.dat", FileMode.OpenOrCreate))
        {
            Book newBook = (Book)formatter.Deserialize(secondStream);
            Console.WriteLine($"Название книги: {newBook.NameOfThePrintPublication}");
        }
        
        //SOAP-формат
        SoapFormatter formatterSoap = new SoapFormatter();

        using (FileStream thirdStream = new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\SOAP.dat", FileMode.OpenOrCreate)) 
        {
            formatterSoap.Serialize(thirdStream, firstBook);
        }

        using (FileStream fourthStream = new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\SOAP.dat", FileMode.OpenOrCreate))
        {
            Book newBookSoap = (Book)formatterSoap.Deserialize(fourthStream);
            Console.WriteLine($"Тип переплёта: {newBookSoap.TypeOfBinding}");
        }
        
        //JSON
        var options = new JsonSerializerOptions { WriteIndented = true };
        
        string json = JsonSerializer.Serialize(firstBook, options);
        File.WriteAllText(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Book.json", json);
        Console.WriteLine(json);
    }
}