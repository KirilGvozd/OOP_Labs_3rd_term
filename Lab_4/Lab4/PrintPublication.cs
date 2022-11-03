namespace Lab4;

public abstract class PrintPublication
{
    protected string? NameOfThePrintPublication;
    protected int AmountOfPages;
    protected int YearOfPublication;

    public virtual void Reading()
    {
        Console.WriteLine("Reading some print publication.") ;
    }

    public abstract void TestFunction();
}