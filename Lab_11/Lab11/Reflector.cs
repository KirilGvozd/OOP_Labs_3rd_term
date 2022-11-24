using System.Reflection;
namespace Lab11;

public static class Reflector
{
    private static StreamWriter? _s;
    public static void GetNameOfTheAssembly(string? className)
    {
        _s = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_11\Lab11\File.txt", true);
        Type? currentClass = Type.GetType(className!, true, true);
        
        string assemblyName = currentClass!.Assembly.ToString();
        _s.WriteLine($"\nИмя класса: {className}. Имя сборки: {assemblyName}\n");
        _s.Close();
    }

    public static void IsTherePublicConstructor(string? className)
    {
        _s = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_11\Lab11\File.txt", true);
        Type? currentClass = Type.GetType(className!, true, true);

        foreach (var constructor in currentClass!.GetConstructors(BindingFlags.Public | BindingFlags.Instance))
        {
            _s.WriteLine(constructor.IsPublic ? $"\nВ классе {className} есть публичный конструктор.\n" : $"\nВ классе {className} нет публичных конструкторов.\n");
        }
        _s.Close();
    }
    public static void WritePublicMethods(string className)
    {
        _s = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_11\Lab11\File.txt", true);
        Type? currentClass = Type.GetType(className, true, true);
        
        IEnumerable<string?> publicMethods = new List<string?>(GetPublicMethods(currentClass!));
        _s.WriteLine($"\nВсе публичные методы в классе {className}:");
        foreach (var item in publicMethods)
        {
            _s.WriteLine(item);
        }
        _s.WriteLine();
        _s.Close();
    }

    public static void WriteAllFieldsAndProperties(string className)
    {
        _s = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_11\Lab11\File.txt", true);
        Type? currentClass = Type.GetType(className, true, true);

        IEnumerable<MemberInfo[]> allFieldsAndProperties = new List<MemberInfo[]>(GetAllFieldsAndProperties(currentClass!));
        _s.WriteLine($"\nВсе поля и свойства в классе {className}:");
        foreach (var dummy in allFieldsAndProperties)
        {
            foreach (var i in dummy)
            {
                _s.WriteLine(i.ToString());
            }
        }
        _s.WriteLine();
        _s.Close();
    }

    public static void WriteAllInterfaces(string className)
    {
        _s = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_11\Lab11\File.txt", true);
        Type? currentClass = Type.GetType(className, true, true);

        IEnumerable<string> allInterfaces = new List<string>(GetAllInterfaces(currentClass!));
        _s.WriteLine($"\nВсе интерфейсы в классе {className}:");
        foreach (var variaInterface in allInterfaces)
        {
            _s.WriteLine(variaInterface);
        }
        _s.WriteLine();
        _s.Close();
    }

    public static void WriteAllClassMethodsWithParameter(string className, string userParameter)
    {
        _s = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_11\Lab11\File.txt", true);
        Type? currentClass = Type.GetType(className, true, true);

        IEnumerable<string> methodsWithUserParameter =
            new List<string>(GetAllMethodsWithUserParameter(currentClass!, userParameter));
        
        _s.WriteLine($"\nВсе методы с параметром {userParameter}:");
        foreach (var method in methodsWithUserParameter)
        {
            _s.WriteLine(method);
        }
        _s.WriteLine();
        _s.Close();
    }

    public static void Invoke(string className, string methodName)
    {
        try
        {
            object? obj = Activator.CreateInstance(Type.GetType(className)!);
            var method = Type.GetType(className)!.GetMethod(methodName);
            List<string> list = File.ReadAllLines(@"D:\Semestr_3\OOP_Labs\Lab_11\Lab11\ForInvokeMethod.txt").ToList();
            object?[] list2 = { list };
            method!.Invoke(obj, list2);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
    
    public static object Create(string className)
    {
        return Activator.CreateInstance(Type.GetType(className));
    }


    private static IEnumerable<string?> GetPublicMethods(Type className)
    {
        var publicMethods = new List<string?>();
        foreach (var item in className.GetMethods(BindingFlags.Public | BindingFlags.Instance))
            if (item.IsPublic)
            {
                publicMethods.Add(item.ToString());
            }
        return publicMethods;
    }

    private static IEnumerable<MemberInfo[]> GetAllFieldsAndProperties(Type className)
    {
        return new List<MemberInfo[]>
        {
            // ReSharper disable once CoVariantArrayConversion
            className.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic),
            // ReSharper disable once CoVariantArrayConversion
            className.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic)
        };
    }

    private static IEnumerable<string> GetAllInterfaces(Type className)
    {
        var interfaces = new List<string>();
        foreach (var iInterface in className.GetInterfaces())
        {
            if (iInterface.IsPublic)
            {
                interfaces.Add(iInterface.ToString());
            }
        }

        return interfaces;
    }

    private static IEnumerable<string> GetAllMethodsWithUserParameter(Type className, string userParameter)
    {
        var methods = new List<string>();
        var currentClassMethods = className.GetMethods();

        foreach (var item in currentClassMethods)
        {
            var parameter = item.GetParameters();
            if (parameter.Any(param => param.Name == userParameter))
            {
                methods.Add(item.ToString()!);
            }
        }
        
        return methods;
    }
}