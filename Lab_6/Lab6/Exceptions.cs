namespace Lab6;

public class PrintPublicationException : Exception
{
    public string? ErrorInClass { get; private set; }

    public PrintPublicationException(string errorInClass, string message) : base(message)
    {
        ErrorInClass = errorInClass;
    }
}

public class YearException : PrintPublicationException
{
    public string? ErrorInYear { get; private set; }

    public YearException(string errorInYear, string message, string errorInClass) : base(errorInClass, message)
    {
        ErrorInYear = errorInYear;
    }
}

public class CostException : PrintPublicationException
{
    public string? ErrorInPrice { get; private set; }

    public CostException(string errorInPrice, string message, string errorInClass) : base(errorInClass, message)
    {
        ErrorInPrice = errorInPrice;
    }
}