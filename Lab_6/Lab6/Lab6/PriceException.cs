namespace Lab6;

public class PriceException : Exception
{
    private string ErrorInPriceMessage { get; set; }
    public double Price { get; private set; }

    public PriceException(string message, double price) : base(message)
    {
        Price = price;
    }
}