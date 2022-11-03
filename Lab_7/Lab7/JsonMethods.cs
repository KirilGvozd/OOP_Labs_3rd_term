using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace Lab7;

public class JsonMethods
{
    public static void WriteList<T>(Stack<T> stack)
    {
        JsonSerializer serializer = new JsonSerializer();
        serializer.Converters.Add(new JavaScriptDateTimeConverter());
        serializer.NullValueHandling = NullValueHandling.Ignore;
        using StreamWriter sw = new StreamWriter(@"D:\Semestr_3\OOP_Labs\Lab_7\Lab7\Lab7.json");
        using JsonWriter writer = new JsonTextWriter(sw);
        writer.Formatting = Formatting.Indented;
        serializer.Serialize(writer, stack.List);
    }

    public static void CreatePresentJson<T>(Stack<T> stack)
    {
        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
        };
        using var stream = new StreamReader(@"D:\Semestr_3\OOP_Labs\Lab_7\Lab7\Lab7.json");
        string JsonData = stream.ReadToEnd();

        List<T> deserialisationList = JsonConvert.DeserializeObject<List<T>>(JsonData, settings);
        foreach (var item in deserialisationList)
            stack.AddItem(item);
    }
}