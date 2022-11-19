namespace Lab10;

public class Lab10
{
    public static void Main()
    {
        string[] months = new[]
        {
            "January", "February", "March", "April", "May", "June", "July", "August", "September", "October",
            "November", "December"
        };
        var lengthQuery =
            from month in months
            where month.Length == 5
            select month;
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

        Console.WriteLine("\nМесяцы в алфавитном порядке:");
        var sortedMonths =
            from month in months
            orderby month
            select month;
        foreach (var month in sortedMonths)
        {
            Console.Write($"{month} ");
        }

        Console.WriteLine("Месяцы, содержащие \"u\" и длиной не менее 4-х символов:");
        var monthsWithUWord =
            from month in months
            where month.Contains('u') && month.Length >= 4
            select month;
        foreach (var month in monthsWithUWord)
        {
            Console.Write($"{month} ");
        }
        
    }
}