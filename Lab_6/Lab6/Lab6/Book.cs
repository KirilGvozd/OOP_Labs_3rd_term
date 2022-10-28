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

    public Book(string? nameOfThePrintPublication, string? nameOfTheAuthor, string? surnameOfTheAuthor, int amountOfPages, double priceOfThePrintPublication)
    {
        if (nameOfTheAuthor == "")
        {
            throw new NameException("Вы не указали имя автора", nameOfTheAuthor);
        }

        if (priceOfThePrintPublication < 0)
        {
            throw new PriceException("Цена меньше нуля", priceOfThePrintPublication);
        }

        if (amountOfPages < 0)
        {
            throw new NumberOfPagesException("Количество страниц меньше нуля", amountOfPages);
        }
        if (priceOfThePrintPublication == 0)
        {
            throw new PriceException("Цена равна нулю", priceOfThePrintPublication);
        }

        if (amountOfPages == 0)
        {
            throw new NumberOfPagesException("Количество страниц равно нулю", amountOfPages);
        }
        
        NameOfThePerson = nameOfTheAuthor;
        SurnameOfThePerson = surnameOfTheAuthor;
        NameOfThePrintPublication = nameOfThePrintPublication;
        AmountOfPages = amountOfPages;
        PriceOfThePrintPublication = priceOfThePrintPublication;
    }

    public override string ToString()
    {
        return $"Name of the book: {this.NameOfThePrintPublication}, Price: {this.PriceOfThePrintPublication}, Year of publication: {YearOfPublication}.";
    }
}