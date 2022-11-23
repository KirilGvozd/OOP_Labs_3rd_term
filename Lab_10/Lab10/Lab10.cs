namespace Lab10;

public static class Lab10
{
    public static void Main()
    {
        string[] months = 
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
            "November", "December"
        };
        var lengthQuery =
            from month in months
            where month.Length == 5
            select month;

        Console.WriteLine("Месяцы, длина которых равна 5:");
        foreach (var month in lengthQuery)
        {
            Console.Write($"{month} ");
        }

        Console.WriteLine("\nЗимние и летние месяцы:");
        var summerAndWinterMonths =
            from month in months
            where Array.IndexOf(months, month) < 2 ||
                  (Array.IndexOf(months, month) > 4 && Array.IndexOf(months, month) < 8) ||
                  Array.IndexOf(months, month) == 11
            select month;
        foreach (var month in summerAndWinterMonths)
        {
            Console.Write($"{month} ");
        }

        Console.WriteLine("\n\nМесяцы в алфавитном порядке:");
        var sortedMonths =
            from month in months
            orderby month
            select month;
        foreach (var month in sortedMonths)
        {
            Console.Write($"{month} ");
        }

        Console.WriteLine("\n\nМесяцы, содержащие \"u\" и длиной не менее 4-х символов:");
        var monthsWithUWord =
            from month in months
            where month.Contains('u') && month.Length >= 4
            select month;
        foreach (var month in monthsWithUWord)
        {
            Console.Write($"{month} ");
        }
        
        //2 задание
        List<Book> listOfBooks = new List<Book>();
        Book aboutLove = new Book("О любви", "Чехов А.П.", 1898, 4, 0);
        Book code = new Book("Код. Тайный язык информатики", "Чарльз Петцольд", 1999, 393, 61.91);
        Book mastersOfDoom = new Book("Властелины Doom", "Дэвид Кушнер", 2003, 420, 13.92);
        Book consoleWars = new Book("Консольные войны", "Блейк Дж.Харрис", 2015, 592, 42.27);
        Book annCarenina = new Book("Анна Каренина", "Толстой Л.Н.", 1878, 864, 11.8);
        Book warAndPeace = new Book("Война и Мир", "Толстой Л.Н.", 1865, 1500, 16.67);
        Book theIdiot = new Book("Идиот", "Достоевский Ф.М.", 1868, 640, 11.53);
        Book karamazovBrothers = new Book("Братья Карамазовы", "Достоевский Ф.М.", 1880, 800, 13);
        Book crimeAndPunishment = new Book("Преступление и наказание", "Достоевский Ф.М.", 1866, 608, 25.24);
        Book mother = new Book("Мать", "Горький Максим", 1906, 416, 11.53);
        listOfBooks.Add(aboutLove);
        listOfBooks.Add(code);
        listOfBooks.Add(mastersOfDoom);
        listOfBooks.Add(consoleWars);
        listOfBooks.Add(annCarenina);
        listOfBooks.Add(warAndPeace);
        listOfBooks.Add(theIdiot);
        listOfBooks.Add(karamazovBrothers);
        listOfBooks.Add(crimeAndPunishment);
        listOfBooks.Add(mother);

        var firstQuery =
            from book in listOfBooks
            where book.Author == "Толстой Л.Н." && book.YearOfPublishing == 1865
            select book;
        Console.WriteLine("\n\nКниги Толстого Л.Н., выпущенные в 1865 году:\n");
        foreach (var book in firstQuery)
        {
            Console.WriteLine(book);
        }

        var secondQuery =
            from book in listOfBooks
            where book.YearOfPublishing > 1900
            select book;
        Console.WriteLine("\nКниги, выпущенные после 1900 года:\n");
        foreach (var book in secondQuery)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nСамая тонкая книга:\n");
        var thinnestBook =
            from book in listOfBooks
            where book.AmountOfPages == listOfBooks.Min(b => b.AmountOfPages)
            select book;
        foreach (var book in thinnestBook)
        {
            Console.WriteLine(book);
        }

        Console.WriteLine("\nПять первых самых толстых книг по низкой цене:\n");
        var thickAndCheapBooks =
            from book in listOfBooks
            orderby book.AmountOfPages descending, book.Price
            select book;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(thickAndCheapBooks.ToList()[i]);
        }

        Console.WriteLine("\nКниги, отсортированные по цене:\n");
        var sortedPrices =
            from book in listOfBooks
            orderby book.Price
            select book;
        foreach (var book in sortedPrices)
        {
            Console.WriteLine(book);
        }
        
        //4 задание
        Console.WriteLine("\nМой уникальный запрос (сумма страниц топ-3 дешёвых книг более 200 страниц), но первый элемен запроса игнорируется:");
        var uniqueQuery = listOfBooks.OrderBy(price => price.Price).Where(pages => pages.AmountOfPages > 200).Take(3).Skip(1).Sum(pages => pages.AmountOfPages);
        /*
        var testQuery = listOfBooks.OrderBy(price => price.Price).Where(pages => pages.AmountOfPages > 200).Take(3).Skip(1); // Тестовый запрос для проверки работоспособности уникального запроса
        foreach (var book in testQuery)
        {
            Console.WriteLine(book);
        }
        */
        Console.WriteLine(uniqueQuery);
        
        //5 задание
        string[] mostLovedLanguages = { "Rust" , "Python", "Swift", "Go", "C#"};
        int[] theirPosition = { 1, 6, 8, 10, 12 };
        var joinOperator = mostLovedLanguages.Join(theirPosition, s => s.Length, i => i, (s, i) => new
        {
            language = $"{s} ",
            position = i,
        });

        Console.WriteLine("\nРезультат применения оператора Join:");
        foreach (var language in joinOperator)
        {
            Console.WriteLine(language);
        }
    }
}