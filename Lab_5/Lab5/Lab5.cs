namespace Lab5;

static class Lab5
{
        public static void Main()
        {
                //Объекты классов
                Book forWhomTheBellTolls = new Book("Hard binding", "For Whom The Bell Tolls", "Ernest", "Hemingway",
                        490, 1940, 20.5);

                var time = new Magazine("Time Inc.", "Time", 50, 2021);
                var warAndPeace = new Book("Hard cover", "War And Peace", "Leo", "Tolstoy", 1500, 1865, 42.5);
                var mathAlgebra = new WorkBook(7, "Algebra", "Algebra 7th class", 120, 2011);

                var arrayOfObjects = new IInformationAboutPublication[3];
                arrayOfObjects[0] = time;
                arrayOfObjects[1] = warAndPeace;
                arrayOfObjects[2] = mathAlgebra;

                var printer = new Printer();

                foreach (var item in arrayOfObjects)
                {
                        printer.IAmPrinting(item);
                }
                
                //Перечисление
                People group = People.Alexander;
                Console.WriteLine(group);
                
                //Структура
                Car passat = new Car(1.8, 5, "Volkswagen", "Sedan");
                Console.WriteLine($"Our car is {passat.NameOfTheManufacterer} with the engine capacity of {passat.EngineCapacity}l. This is a {passat.TypeOfCar} with {passat.NumberOfSeats} seats.");
                
                //Класс-контейнер
                Library firstLibrary = new Library();
                
                firstLibrary.AddItem(warAndPeace);
                firstLibrary.AddItem(forWhomTheBellTolls);
                firstLibrary.PrintList();
                
                //Метод из класса-контроллера
                foreach (var item in LibraryController.PrintBooks(firstLibrary, 1900))
                {
                        Console.WriteLine(item.ToString());
                }
                
                LibraryController.TextReader(firstLibrary);
                firstLibrary.PrintList();
                
                //JSON
                LibraryController.JsonWriter(firstLibrary);
                firstLibrary.PrintList();
        }
}
