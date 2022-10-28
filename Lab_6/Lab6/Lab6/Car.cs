namespace Lab6;

public struct Car
{
    public readonly double EngineCapacity;
    public readonly int NumberOfSeats;
    public readonly string NameOfTheManufacterer;
    public readonly string TypeOfCar;

    public Car(double engineCapacity, int numberOfSeats, string nameOfTheManufacterer, string typeOfCar)
    {
        this.EngineCapacity = engineCapacity;
        this.NumberOfSeats = numberOfSeats;
        this.TypeOfCar = typeOfCar;
        this.NameOfTheManufacterer = nameOfTheManufacterer;
    }
}