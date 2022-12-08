namespace Lab13;

[Serializable]
public class Book : PrintPublication, IInformationAboutPublication
{
    public readonly string? TypeOfBinding;
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
        Console.WriteLine("Type of the binding in this book: " + TypeOfBinding);
    }

    public Book(string? typeOfBinding, string? nameOfThePrintPublication, int amountOfPages, int yearOfPublication)
    {
        TypeOfBinding = typeOfBinding;
        NameOfThePrintPublication = nameOfThePrintPublication;
        AmountOfPages = amountOfPages;
        YearOfPublication = yearOfPublication;
    }

    public override string ToString()
    {
        return $"Type: {this.GetType()}, Pages: {this.AmountOfPages}";
    }
}