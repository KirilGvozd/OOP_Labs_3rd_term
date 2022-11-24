using Lab10;
namespace Lab11;

public static class Lab11
{
    public static void Main()
    {
        //Тест на своих классах
        Reflector.GetNameOfTheAssembly("Lab11.Computer, Lab11");
        Reflector.WriteAllFieldsAndProperties("Lab11.Computer, Lab11");
        Reflector.WriteAllInterfaces("Lab11.Computer, Lab11");
        Reflector.WriteAllClassMethodsWithParameter("Lab11.Computer, Lab11", "amount");
        Reflector.Invoke("Lab11.Computer, Lab11", "MountingVideocard");
        
        Reflector.IsTherePublicConstructor("Lab10.Book, Lab11");
        Reflector.WritePublicMethods("Lab10.Book, Lab11");
        Reflector.WriteAllFieldsAndProperties("Lab10.Book, Lab11");
        Reflector.GetNameOfTheAssembly("Lab10.Book, Lab11");
        
        //Тест на стандартных классах .NET
        Reflector.GetNameOfTheAssembly("System.String");
        Reflector.IsTherePublicConstructor("System.String");
        Reflector.WritePublicMethods("System.String");

        //2 задание
        var book = Reflector.Create("Lab10.Book");
        if (book is Book)
        {
            Console.WriteLine("\nЭто объект типа Book.");
        }
        else
        {
            Console.WriteLine("\nЭтот объект не типа Book.");
        }
    }
}