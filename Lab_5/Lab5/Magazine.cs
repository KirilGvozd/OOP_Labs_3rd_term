namespace Lab5;

public class Magazine : PrintPublication, IInformationAboutPublication
{
    private readonly string? _nameOfTheMedia;

    public override void TestFunction()
    {
        Console.WriteLine("This is test function from abstract class PrintPublication. Class Magazine.");
    }

    void IInformationAboutPublication.TestFunction()
    {
        Console.WriteLine("This is a test function from interface.");
    }
    public override void Reading()
    {
        Console.WriteLine("Reading " + NameOfThePrintPublication + " magazine.");
    }

    public void InformationAboutPrintPublication()
    {
        Console.WriteLine("Name of the magazine: " + NameOfThePrintPublication);
        Console.WriteLine("Amount of pages: " + AmountOfPages);
        Console.WriteLine("Year of publication: " + YearOfPublication);
        Console.WriteLine("Name of the media that publishing it: " + _nameOfTheMedia);
    }

    public Magazine(string? nameOfTheMedia, string? nameOfThePrintPublication, int amountOfPages, int yearOfPublication)
    {
        _nameOfTheMedia = nameOfTheMedia;
        NameOfThePrintPublication = nameOfThePrintPublication;
        AmountOfPages = amountOfPages;
        YearOfPublication = yearOfPublication;
    }

    public override string ToString()
    {
        return $"Name of the book: {this.NameOfThePrintPublication}, Price: {this.PriceOfThePrintPublication}, Year of publication: {YearOfPublication}.";
    }
    
}