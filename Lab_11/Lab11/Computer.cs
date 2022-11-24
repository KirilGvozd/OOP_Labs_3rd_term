namespace Lab11;

public class Computer
{
    public string? VideoCard { get; set; }
    private string? Processor { get; set; }
    public int AmountOfRam { get; set; }
    private int AmountOfStorage { get; set; }


    public Computer()
    {
        
    }
    public Computer(string videoCard, string processor, int amountOfRam, int amountOfStorage)
    {
        VideoCard = videoCard;
        Processor = processor;
        AmountOfRam = amountOfRam;
        AmountOfStorage = amountOfStorage;
    }

    public void IsWorking()
    {
        Console.WriteLine("Computer is working.\n");
    }

    public void AddingRam(int amount)
    {
        Console.WriteLine("Adding " + amount + "GB of RAN to your system.\n");
        AmountOfRam += amount;
    }

    public void AddingStorage(int amountOfStorage)
    {
        Console.WriteLine("Adding " + amountOfStorage + "GB of SSD to your system.\n");
        AmountOfStorage += amountOfStorage;
    }

    public void MountingVideocard(List<string> nameOfVideoCard)
    {
        foreach (var name in nameOfVideoCard)
        {
            Console.WriteLine($"Вы поставили видеокарту {name}");
        }
    }
}