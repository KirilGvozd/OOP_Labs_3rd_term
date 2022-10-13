namespace Lab4;

public class Magazine : PrintPublication
{
    public override void Reading()
    {
        Console.WriteLine("Reading " + NameOfThePrintPublication + " magazine.");
    }

    public override void InformationAboutPrintPublication()
    {
        Console.WriteLine("Name of the magazine: " + NameOfThePrintPublication);
        Console.WriteLine("Amount of pages: " + AmountOfPages);
        Console.WriteLine("Year of publication: " + YearOfPublication);
    }
    
    public Magazine(string? nameOfThePrintPublication, int amountOfPages, int yearOfPublication)
    {
        this.NameOfThePrintPublication = nameOfThePrintPublication ??
                                         throw new ArgumentNullException(nameof(nameOfThePrintPublication));
        this.AmountOfPages = amountOfPages;
        this.YearOfPublication = yearOfPublication;
    }

}