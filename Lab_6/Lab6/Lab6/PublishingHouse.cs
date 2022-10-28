namespace Lab6;

public sealed class PublishingHouse
{
    private string? NameOfThePublishingHouse { get; }
    private int _id;

    private int Id
    {
        get => _id;
        set
        {
            _id = value;
            _id = GetHashCode();
        }
    }


    public void PublishingBook()
    {
        Console.WriteLine("Book published.");
    }


    //Override methods
    public override bool Equals(object? obj)
    {
        if (obj == null)
        {
            return false;
        }
        PublishingHouse house = obj as PublishingHouse ?? throw new InvalidOperationException();
        return house.Id == this.Id;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string ToString()
    {
        return $"Id of the publishing house: {this.Id}.\n" +
               $"Name of the publishing house: {this.NameOfThePublishingHouse}.\n";
    }
}