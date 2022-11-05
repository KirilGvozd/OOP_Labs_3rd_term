using Newtonsoft.Json;
namespace Lab7;

public static class Lab7
{
    public static void Main()
    {
        //Задание 2
        try
        {
            Stack<string> names = new Stack<string>();
            names.AddItem("Kirill");
            names.AddItem("Oleg");
            names.AddItem("Anton");
            Console.WriteLine("Первое имя в стеке: " + names.Peek());
            Console.WriteLine("Всего имён в стеке: " + names.List.Count);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Console.WriteLine(e.StackTrace);
        }
        finally
        {
            Console.WriteLine("Блок finally.");
        }
        
        //Задание 3
        Stack<int> secondStack = new Stack<int>();
        secondStack.AddItem(1);
        secondStack.AddItem(2);
        secondStack.LookUp();
        secondStack.DeleteItem();
        secondStack.LookUp();
        Stack<float> thirdStack = new Stack<float>();
        thirdStack.AddItem(1.33f);
        thirdStack.AddItem(1.44f);
        thirdStack.LookUp();
        thirdStack.DeleteItem();
        thirdStack.LookUp();
        
        //Задание 4
        Stack<PrintPublication> books = new Stack<PrintPublication>();
        books.AddItem(new PrintPublication("War And Peace"));
        books.AddItem(new PrintPublication("Mother"));
        books.LookUp();
        
        //Задание 5
        JsonMethods.WriteList(books);
        Stack<PrintPublication> magazines = new Stack<PrintPublication>();
        JsonMethods.CreatePresentJson(magazines);
        magazines.LookUp();
    }
}