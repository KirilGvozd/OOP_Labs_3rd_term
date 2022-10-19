namespace Lab5;

public struct Car
{
    public double engineCapacity;
    public int numberOfSeats;
    public string nameOfTheManufacter;
    public string typeOfCar;

    public Car(double engineCapacity, int numberOfSeats, string nameOfTheManufacter, string typeOfCar)
    {
        this.engineCapacity = engineCapacity;
        this.numberOfSeats = numberOfSeats;
        this.typeOfCar = typeOfCar;
        this.nameOfTheManufacter = nameOfTheManufacter;
    }
}