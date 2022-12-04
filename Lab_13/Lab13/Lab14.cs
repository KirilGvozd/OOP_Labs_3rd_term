using System.Runtime.Serialization.Formatters.Binary;

namespace Lab13;

public static class Lab14
{
    public static void Main()
    {
        Book firstBook = new Book("Soft", "War and Peace", 1500, 1865);
        BinaryFormatter formatter = new BinaryFormatter();
        
        using (FileStream newStream = new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Binary.dat", FileMode.OpenOrCreate))
        {
            formatter.Serialize(newStream, firstBook);
        }

        using (FileStream secondStream = new FileStream("Binary.dat", FileMode.OpenOrCreate))
        {
            Book newBook = (Book)formatter.Deserialize(secondStream);
            Console.WriteLine($"Название книги: {newBook.NameOfThePrintPublication}");
        }
    }
}

