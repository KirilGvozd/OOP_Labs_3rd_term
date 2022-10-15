namespace Lab4;

public class Book : PrintPublication, IInformationAboutPublication
{
    private readonly string? _typeOfBinding;
    
    public override void TestFunction()
    {
        Console.WriteLine("This is test function from abstract class PrintPublication. Class Book.");
    }

    void IInformationAboutPublication.TestFunction()
    {
        Console.WriteLine("This is a test function from interface. Class Book.");
    }

    public override void Reading()
    {
        Console.WriteLine("Reading " + NameOfThePrintPublication);
    }

    public  void InformationAboutPrintPublication()
    {
        Console.WriteLine("Name of the book: " + NameOfThePrintPublication);
        Console.WriteLine("Amount of pages: " + AmountOfPages);
        Console.WriteLine("Year of publication: " + YearOfPublication);
        Console.WriteLine("Type of the binding in this book: " + _typeOfBinding);
        Console.WriteLine("Author of this book is " + this.NameOfThePerson + " " + this.SurnameOfThePerson);
    }

    public Book(string? typeOfBinding, string? nameOfThePrintPublication, string? nameOfTheAuthor, string? surnameOfTheAuthor, int amountOfPages, int yearOfPublication)
    {
        NameOfThePerson = nameOfTheAuthor;
        SurnameOfThePerson = surnameOfTheAuthor;
        _typeOfBinding = typeOfBinding;
        NameOfThePrintPublication = nameOfThePrintPublication;
        AmountOfPages = amountOfPages;
        YearOfPublication = yearOfPublication;
    }

    public override string ToString()
    {
        return $"Type: {this.GetType()}, Pages: {this.AmountOfPages}";
    }
}