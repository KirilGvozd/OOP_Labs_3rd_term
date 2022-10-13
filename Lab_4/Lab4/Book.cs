namespace Lab4;

public class Book : PrintPublication
{
    public override void Reading()
    {
        Console.WriteLine("Reading " + NameOfThePrintPublication);
    }

    public override void InformationAboutPrintPublication()
    {
        Console.WriteLine("Name of the book: " + NameOfThePrintPublication);
        Console.WriteLine("Amount of pages: " + AmountOfPages);
        Console.WriteLine("Year of publication: " + YearOfPublication);
    }

}