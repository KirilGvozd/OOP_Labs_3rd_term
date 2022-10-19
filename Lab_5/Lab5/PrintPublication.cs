namespace Lab5;

public abstract class PrintPublication : Author
{
    protected string? NameOfThePrintPublication;
    protected int AmountOfPages;
    protected int YearOfPublication;
    protected double PriceOfThePrintPublication;

    public virtual void Reading()
    {
        Console.WriteLine("Reading some print publication.") ;
    }

    public abstract void TestFunction();
}