using System.Reflection;

namespace Lab11;

public static class Lab11
{
    public static void Main()
    {
        Reflector.GetNameOfTheAssembly("Lab11.Reflector");
        Reflector.IsTherePublicConstructor("Lab11.Reflector");
        Reflector.WritePublicMethods("Lab11.Reflector");
        Reflector.WriteAllFieldsAndProperties("Lab11.Reflector");
        Reflector.WriteAllInterfaces("Lab11.Reflector");
    }
}