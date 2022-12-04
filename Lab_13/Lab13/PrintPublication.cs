namespace Lab13;
[Serializable]
public abstract class PrintPublication
{
    public string? NameOfThePrintPublication;
    public int AmountOfPages;
    public int YearOfPublication;

    public virtual void Reading()
    {
        Console.WriteLine("Reading some print publication.") ;
    }

    public abstract void TestFunction();
}