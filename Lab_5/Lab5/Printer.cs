namespace Lab5;

public class Printer
{
    public void IAmPrinting(IInformationAboutPublication informationAboutPublication)
    {
        Console.WriteLine(informationAboutPublication.ToString());
    }
}