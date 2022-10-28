namespace Lab6;

public class Printer
{
    public void IAmPrinting(IInformationAboutPublication informationAboutPublication)
    {
        Console.WriteLine(informationAboutPublication.ToString());
    }
}