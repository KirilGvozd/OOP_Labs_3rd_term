namespace Lab4;

public class Printer
{
    public void IAmPrinting(IInformationAboutPublication informationAboutPublication)
    {
        Console.WriteLine(informationAboutPublication.ToString());
    }
}