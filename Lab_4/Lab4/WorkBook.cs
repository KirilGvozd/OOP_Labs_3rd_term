namespace Lab4;

public class WorkBook : PrintPublication
{
    public override void Reading()
    {
        Console.WriteLine("Reading and learning " + NameOfThePrintPublication);
    }

    public override void InformationAboutPrintPublication()
    {
        Console.WriteLine("Name of the workbook: " + NameOfThePrintPublication);
        Console.WriteLine("Amount of pages: " + AmountOfPages);
        Console.WriteLine("Year of publication: " + YearOfPublication);
    }

}