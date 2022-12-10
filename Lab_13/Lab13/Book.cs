namespace Lab13;

[Serializable]
public class Book : PrintPublication, IInformationAboutPublication
{
    [NonSerialized] 
    public string? TypeOfBinding = "Мягкий";
    public override void TestFunction()
    {
        Console.WriteLine("\nЧитаю книгу");
    }

    void IInformationAboutPublication.ReadingABook()
    {
        Console.WriteLine("\nЧитаю книгу.");
    }

    public override void Reading()
    {
        Console.WriteLine("\nЧитаю " + NameOfThePrintPublication);
    }

    public  void InformationAboutPrintPublication()
    {
        Console.WriteLine("\nНазвание книги: " + NameOfThePrintPublication);
        Console.WriteLine("Кол-во страниц: " + AmountOfPages);
        Console.WriteLine("Год издания: " + YearOfPublication);
        Console.WriteLine("Тип переплёта: " + TypeOfBinding);
    }

    public Book(string? nameOfThePrintPublication, int amountOfPages, int yearOfPublication)
    {
        NameOfThePrintPublication = nameOfThePrintPublication;
        AmountOfPages = amountOfPages;
        YearOfPublication = yearOfPublication;
    }

    public Book() {}

    public override string ToString()
    {
        return $"\nНазвание книги: {NameOfThePrintPublication}\nКол-во страниц: {AmountOfPages}\nГод издания: {YearOfPublication}\nТип переплёта: {TypeOfBinding}";
    }
}