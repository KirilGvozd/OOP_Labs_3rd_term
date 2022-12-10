namespace Lab13;
[Serializable]
public abstract class PrintPublication
{
    public string? NameOfThePrintPublication { get; set; }
    public int AmountOfPages { get; set; }
    public int YearOfPublication { get; set; }

    public virtual void Reading()
    {
        Console.WriteLine("Reading some print publication.") ;
    }

    public abstract void TestFunction();
}