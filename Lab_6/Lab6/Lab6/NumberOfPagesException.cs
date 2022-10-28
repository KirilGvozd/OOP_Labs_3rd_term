namespace Lab6;

public class NumberOfPagesException : Exception
{
    private string ErrorInNumberOfPagesMessage { get; set; }
    public int NumberOfPages { get; private set; }

    public NumberOfPagesException(string message, int numberOfPages) : base(message)
    {
        NumberOfPages = numberOfPages;
    }
}