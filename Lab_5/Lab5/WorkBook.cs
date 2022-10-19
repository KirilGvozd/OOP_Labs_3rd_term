namespace Lab5;

public class WorkBook : PrintPublication, IInformationAboutPublication
{
    private readonly int _numberOfClass;
    private readonly string? _typeOfSubject;
    
    public override void TestFunction()
    {
        Console.WriteLine("This is test function from abstract class PrintPublication. Class WorkBook.");
    }

    void IInformationAboutPublication.TestFunction()
    {
        Console.WriteLine("This is a test function from interface.");
    }

    public override void Reading()
    {
        Console.WriteLine("Reading and learning " + NameOfThePrintPublication);
    }

    public void InformationAboutPrintPublication()
    {
        Console.WriteLine("Number of class: " + this._numberOfClass);
        Console.WriteLine("Type of subject: " + this._typeOfSubject);
        Console.WriteLine("Name of the workbook: " + this.NameOfThePrintPublication);
        Console.WriteLine("Amount of pages: " + this.AmountOfPages);
        Console.WriteLine("Year of publication: " + this.YearOfPublication);
        Console.WriteLine("Author of this workbook " + this.NameOfThePerson + " " + this.SurnameOfThePerson);
    }

    public WorkBook(int numberOfClass, string? typeOfSubject, string? nameOfThePrintPublication, int amountOfPages, int yearOfPublication)
    {
        _numberOfClass = numberOfClass;
        _typeOfSubject = typeOfSubject;
        NameOfThePrintPublication = nameOfThePrintPublication;
        AmountOfPages = amountOfPages;
        YearOfPublication = yearOfPublication;
    }

    public override string ToString()
    {
        return $"Name of the book: {this.NameOfThePrintPublication}, Price: {this.PriceOfThePrintPublication}, Year of publication: {YearOfPublication}.";
    }
}