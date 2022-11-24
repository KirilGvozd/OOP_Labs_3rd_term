using System.Reflection;

namespace Lab11;

public static class Lab11
{
    public static void Main()
    {
        Reflector.GetNameOfTheAssembly("Lab11.Computer, Lab11");
        Reflector.IsTherePublicConstructor("Lab11.Computer, Lab11");
        Reflector.WritePublicMethods("Lab11.Computer, Lab11");
        Reflector.WriteAllFieldsAndProperties("Lab11.Reflector, Lab11");
        Reflector.WriteAllInterfaces("Lab11.Computer, Lab11");
        Reflector.WriteAllClassMethodsWithParameter("Lab11.Computer, Lab11", "amount");
        Reflector.Invoke("Lab11.Computer, Lab11", "MountingVideocard");
        
    }
}