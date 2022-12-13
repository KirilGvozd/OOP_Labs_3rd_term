using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Runtime.Serialization.Json;
using System.Text.Json;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;


namespace Lab13;

public static class Lab13
{
    [Obsolete("Obsolete")]
    public static void Main()
    {
        //1 задание

        //Binary-формат
        Book warAndPeace = new Book("Война и Мир", 1500, 1865);
        BinaryFormatter binaryFormatter = new BinaryFormatter();

        using (FileStream binarySerializerStream =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Binary.bin", FileMode.OpenOrCreate))
        {
            binaryFormatter.Serialize(binarySerializerStream, warAndPeace);
        }

        using (FileStream binaryDeserializer =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Binary.bin", FileMode.OpenOrCreate))
        {
            Book binaryDeserialized = (Book)binaryFormatter.Deserialize(binaryDeserializer);
            Console.WriteLine($"Название книги: {binaryDeserialized.NameOfThePrintPublication}");
        }

        //SOAP-формат
        SoapFormatter soapFormatter = new SoapFormatter();

        using (FileStream soapSerializer =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\SOAP.xml", FileMode.OpenOrCreate))
        {
            soapFormatter.Serialize(soapSerializer, warAndPeace);
        }

        using (FileStream soapDeserializer =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\SOAP.xml", FileMode.OpenOrCreate))
        {
            Book soapDeserialized = (Book)soapFormatter.Deserialize(soapDeserializer);
            Console.WriteLine($"Тип переплёта: {soapDeserialized.TypeOfBinding}");
        }

        //JSON
        var options = new JsonSerializerOptions { WriteIndented = true };

        using (FileStream jsonSerializer =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Book.json", FileMode.OpenOrCreate))
        {
            JsonSerializer.Serialize(jsonSerializer, warAndPeace, options);
        }

        using (FileStream jsonDeserializer =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Book.json", FileMode.OpenOrCreate))
        {
            Book jsonDeserialized = JsonSerializer.Deserialize<Book>(jsonDeserializer)!;
            Console.WriteLine(
                $"Год выпуска книги {jsonDeserialized.NameOfThePrintPublication}: {jsonDeserialized.YearOfPublication}.");
        }

        //XML
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(Book));

        using (FileStream xmlSerializerStream =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\BookXML.xml", FileMode.OpenOrCreate))
        {
            xmlSerializer.Serialize(xmlSerializerStream, warAndPeace);
        }

        using (FileStream xmlDeserializerStream =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\BookXML.xml", FileMode.OpenOrCreate))
        {
            Book? xmlDeserialized = xmlSerializer.Deserialize(xmlDeserializerStream) as Book;
            Console.WriteLine(
                $"Кол-во страниц в книге {xmlDeserialized!.NameOfThePrintPublication}: {xmlDeserialized.AmountOfPages}");
        }

        //2 задание
        Book allQuiteOnTheWesternFront = new Book("На Западном Фронте Без Перемен", 350, 1918);
        Book forWhomTheBellTolls = new Book("По Ком Звонит Колокол", 200, 1939);

        Book[] arrayOfBooks = { warAndPeace, allQuiteOnTheWesternFront, forWhomTheBellTolls };

        DataContractJsonSerializer jsonArraySerializer = new DataContractJsonSerializer(typeof(Book[]));

        using (FileStream jsonStream =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\JsonArray.json", FileMode.OpenOrCreate))
        {
            jsonArraySerializer.WriteObject(jsonStream, arrayOfBooks);
        }

        using (FileStream jsonDeserializerStream =
               new FileStream(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\JsonArray.json", FileMode.OpenOrCreate))
        {
            Book[] jsonDeserialized = (Book[])jsonArraySerializer.ReadObject(jsonDeserializerStream)!;
            foreach (var book in jsonDeserialized)
            {
                Console.WriteLine(book.ToString());
            }
        }

        //3 задание
        XmlDocument newDocument = new XmlDocument();
        newDocument.Load(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\BookXML.xml");
        XmlElement? root = newDocument.DocumentElement;
        XmlNodeList? nodes = root?.SelectNodes("*");
        Console.WriteLine("\nВсе узлы в BookXML:");
        if (nodes is not null)
        {
            foreach (XmlNode node in nodes)
            {
                Console.WriteLine(node.Name);
            }
        }
        else
        {
            Console.WriteLine("Узлы пустые.");
        }

        Console.WriteLine("\nЧто находится в теге NameOfThePrintPublication:");
        XmlNodeList? nameOfThePrintPublicationNodes = root?.SelectNodes("NameOfThePrintPublication");
        if (nameOfThePrintPublicationNodes is not null)
        {
            foreach (XmlNode node in nameOfThePrintPublicationNodes)
            {
                Console.WriteLine(node.InnerText);
            }
        }
        else
        {
            Console.WriteLine("Узлы пустые.");
        }

        //4 задание
        XDocument xDocument = new XDocument();
        XElement rootElement = new XElement("Cars");

        //Первая машина
        XElement honda = new XElement("Honda");
        XElement nameOfHonda = new XElement("Name", "Civic");
        XElement engineCapacityOfHonda = new XElement("Engine_Capacity", 1.6);
        honda.Add(nameOfHonda);
        honda.Add(engineCapacityOfHonda);

        //Вторая машина
        XElement toyota = new XElement("Toyota");
        XElement nameOfToyota = new XElement("Name", "Corolla");
        XElement engineCapacityOfToyota = new XElement("Engine_Capacity", 1.6);
        toyota.Add(nameOfToyota);
        toyota.Add(engineCapacityOfToyota);

        //Третья машина
        XElement secondToyota = new XElement("Toyota");
        XElement nameOfSecondToyota = new XElement("Name", "Supra");
        XElement engineCapacityOfSecondToyota = new XElement("Engine_Capacity", 2.5);
        secondToyota.Add(nameOfSecondToyota);
        secondToyota.Add(engineCapacityOfSecondToyota);

        rootElement.Add(honda);
        rootElement.Add(toyota);
        rootElement.Add(secondToyota);

        xDocument.Add(rootElement);
        xDocument.Save(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Cars.xml");

        //Linq To XML
        XDocument documentForQueries = XDocument.Load(@"D:\Semestr_3\OOP_Labs\Lab_13\Lab13\Cars.xml");

        Console.WriteLine("\nВыборка только по Тойотам:");
        var onlyToyotas = documentForQueries.Element("Cars")!.Elements("Toyota").Select(p => new
            {
                name = p.Element("Name")?.Value,
                engineCapacity = p.Element("Engine_Capacity")?.Value
            }
        );

        foreach (var car in onlyToyotas)
        {
            Console.WriteLine($"Название модели: {car.name}\nОбъём двигателя: {car.engineCapacity}");
        }

        Console.WriteLine("\nТойоты только с двигателем объёмом 1.6л:");
        var engineCapacityQuery = documentForQueries.Element("Cars")!.Elements("Toyota")
            .Where(p => p.Element("Engine_Capacity")!.Value == "1.6").Select(p => new
            {
                name = p.Element("Name")?.Value,
                engineCapacity = p.Element("Engine_Capacity")?.Value
            });
        foreach (var car in engineCapacityQuery)
        {
            Console.WriteLine($"Название модели: {car.name}\nОбъём двигателя: {car.engineCapacity}");
        }
    }
}