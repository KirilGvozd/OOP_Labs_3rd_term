namespace Lab6;

public partial class Book : PrintPublication, IInformationAboutPublication
{
    private readonly string? _typeOfBinding;
    
    public override void Reading()
    {
        Console.WriteLine("Reading " + NameOfThePrintPublication);
    }

    public void InformationAboutPrintPublication()
    {
        Console.WriteLine("Name of the book: " + NameOfThePrintPublication);
        Console.WriteLine("Amount of pages: " + AmountOfPages);
        Console.WriteLine("Year of publication: " + YearOfPublication);
        Console.WriteLine("Type of the binding in this book: " + _typeOfBinding);
        Console.WriteLine("Author of this book is " + this.NameOfThePerson + " " + this.SurnameOfThePerson);
    }

    public Book(string? typeOfBinding, string? nameOfThePrintPublication, string? nameOfTheAuthor, string? surnameOfTheAuthor, int amountOfPages, int yearOfPublication, double priceOfThePrintPublication)
    { 
        NameOfThePerson = nameOfTheAuthor;
        SurnameOfThePerson = surnameOfTheAuthor;
        _typeOfBinding = typeOfBinding;
        NameOfThePrintPublication = nameOfThePrintPublication;
        AmountOfPages = amountOfPages;
        YearOfPublication = yearOfPublication;
        PriceOfThePrintPublication = priceOfThePrintPublication;
    }

    public override string ToString()
    {
        return $"Name of the book: {this.NameOfThePrintPublication}, Price: {this.PriceOfThePrintPublication}, Year of publication: {YearOfPublication}.";
    }
}