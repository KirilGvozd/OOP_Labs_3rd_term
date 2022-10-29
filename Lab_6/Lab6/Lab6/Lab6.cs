using System.Diagnostics;

namespace Lab6;

static class Lab6
{
        public static void Main()
        {
                /*
                Book warAndPeace = new Book("War And Peace", "Leo", "Tolstoy", -24, 20.25);
                Debug.Assert(warAndPeace.AmountOfPages > 0, "Количество страниц меньше нуля.");
                */
                //2 задание
                try
                {
                        Book firstBook = new Book("Mother", "", "Gorky", 20, 20.5);
                }
                catch (NameException e)
                {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.StackTrace + "\n");
                }

                try
                {
                        Book secondBook = new Book("War And Peace", "Leo", "Tolstoy", 1500, -29);
                }
                catch (PriceException e)
                {
                        Console.WriteLine("\n" + e.Message);
                        Console.WriteLine("Неверное значение цены книги: " + e.Price);
                        Console.WriteLine(e.StackTrace + "\n");
                }

                try
                {
                        Book thirdBook = new Book("War And Peace", "Leo", "Tolstoy", -200, 20.24);
                }
                catch (NumberOfPagesException e)
                {
                        Console.WriteLine("\n" + e.Message);
                        Console.WriteLine("Неверное количество страниц в книге: " + e.NumberOfPages);
                        Console.WriteLine(e.StackTrace + "\n");
                }

                try
                {
                        Book fourthBook = new Book("War And Peace", "Leo", "Tolstoy", 0, 20.24);
                }
                catch (NumberOfPagesException e)
                {
                        Console.WriteLine("\n" + e.Message);
                        Console.WriteLine(e.StackTrace + "\n");
                }

                //Дополнительное задание с логгером
                try
                {
                        Book thirdBook = new Book("War And Peace", "Leo", "Tolstoy", 200, 0);
                }
                catch (PriceException e)
                {
                        Console.WriteLine("\n" + e.Message);
                        Console.WriteLine(e.StackTrace);
                        Logger.SwitchBetweenFileAndConsole(e);
                        Logger.SwitchBetweenFileAndConsole(e, false);
                }

                //3 задание
                try
                {
                        Book thirdBook = new Book("War And Peace", "", "Tolstoy", -24, -200);
                }
                catch
                {
                        Console.WriteLine("\nНеверные данные!");
                }

                //5 задание
                try
                {
                        Book thirdBook = new Book("War And Peace", "Leo", "Tolstoy", -24, -200);
                }
                catch (PriceException e)
                {
                        Console.WriteLine(e.Message);
                        Console.WriteLine(e.StackTrace + "\n");
                        throw;
                }
                finally
                {
                        Console.WriteLine("Finally, it's over.");
                }
        }
}
