namespace Lab6;

public partial class Book : PrintPublication, IInformationAboutPublication
{
    public override void TestFunction()
    {
        Console.WriteLine("This is test function from abstract class PrintPublication. Class Book.");
    }

    void IInformationAboutPublication.TestFunction()
    {
        Console.WriteLine("This is a test function from interface. Class Book.");
    }

}