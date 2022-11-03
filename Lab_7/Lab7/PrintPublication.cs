namespace Lab7;

public class PrintPublication
{
    public string? NameOfThePrintPublication { get; set; }
    public int AmountOfPages { get; set; }
    public int YearOfPublication { get; set; }

    public PrintPublication(string nameOfThePrintPublication)
    {
        NameOfThePrintPublication = nameOfThePrintPublication;
    }

    public override string ToString()
    {
        return "Название книги: " + this.NameOfThePrintPublication;
    }
}