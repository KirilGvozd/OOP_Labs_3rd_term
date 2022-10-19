namespace Lab5;

class Lab5
{
        public static void Main()
        {
                //Объекты классов
                PrintPublication forbes = new Magazine("Forbes Media LLC", "Forbes", 25, 2022);
                Book forWhomTheBellTolls = new Book("Hard binding", "For Whom The Bell Tolls", "Ernest", "Hemingway",
                        490, 1940, 20.5);
                WorkBook english = new WorkBook(9, "English", "English 9th class", 150, 2019);
                IInformationAboutPublication allQuiteOnTheWesternFront = new Book("Soft binding", "All quite on the Western Front", "Erich Maria", "Remark",
                        200, 1929, 15.25);

                //Через ссылки на абстрактный класс и интерфейс
                forbes.Reading();
                forbes.TestFunction();
                allQuiteOnTheWesternFront.TestFunction();
                
                //Операторы is и as
                if (forbes is Magazine)
                {
                        Console.WriteLine("Forbes is a Magazine object.");
                }
                if (allQuiteOnTheWesternFront is Book)
                {
                        Console.WriteLine("AllQuiteOnTheWesternFront is a Book object.");
                }

                if (english is WorkBook)
                {
                        Console.WriteLine("English is a WorkBook object.");
                }
                if ((english as PrintPublication) != null)
                {
                        Console.WriteLine("Now object english is a PrintPublication object.");
                }
                
                //7 задание с классом Printer
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
                Car passat = new Car(1.8, 5, "Volskwagen", "Sedan");
                Console.WriteLine($"Our car is {passat.nameOfTheManufacter} with the engine capacity of {passat.engineCapacity}l. This is a {passat.typeOfCar} with {passat.numberOfSeats} seats.");
                
                //Класс-контейнер
                Library firstLibrary = new Library();
                
                firstLibrary.AddItem(warAndPeace);
                firstLibrary.AddItem(forWhomTheBellTolls);
                firstLibrary.PrintList();
        }
}
