using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

public class Class1
{
    public static void uncheckedFunction()
    {
        unchecked
        {
            int a = Int32.MaxValue;
            Console.WriteLine(a + 1);
        }
    }

    public static void checkedFunction()
    {
        checked
        {
            int a = Int32.MaxValue;
            Console.WriteLine(a + 1);
        }
    }
    
    public static void Main(string[] args)
    {
         bool IsTrue = true;

         Console.WriteLine("Enter any integer number: ");
         byte firstNumber = Convert.ToByte(Console.ReadLine());
         Console.WriteLine("You entered this number: " + firstNumber);
         
         Console.WriteLine("\nEnter any symbol: ");
         char symbol = Convert.ToChar(Console.ReadLine());
         Console.WriteLine("You entered this symbol: " + symbol);
         
         Console.WriteLine("\nEnter any decimal number: ");
         decimal secondNumber = Convert.ToDecimal(Console.ReadLine());
         Console.WriteLine("You entered this number: " + secondNumber);
         
         Console.WriteLine("\nEnter any number: ");
         double thirdNumber = Convert.ToDouble(Console.ReadLine());
         Console.WriteLine("You entered this number: " + thirdNumber);
         
         Console.WriteLine("\nEnter any number with floating point: ");
         float fourthNumber = Convert.ToSingle(Console.ReadLine());
         Console.WriteLine("You entered this number: " + fourthNumber);
         
         Console.WriteLine("\nEnter any integer number: ");
         int fifthNumber = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("You entered this number: " + fifthNumber);
         
         Console.WriteLine("\nEnter any integer number: ");
         long sixthNumber = Convert.ToInt64(Console.ReadLine());
         Console.WriteLine("You entered this number: " + sixthNumber);
         
         Console.WriteLine("\nEnter any integer number: ");
         short seventhNumber = Convert.ToInt16(Console.ReadLine());
         Console.WriteLine("You entered this number: " + seventhNumber);
         
         //Неявные преобразования
         
         int number_1 = 2412432;
         long number_1_long = number_1;
         
         short number_2 = 1243;
         int number_2_integer = number_2;
         
         byte number_3 = 213;
         short number_3_short = number_3;
         
         uint number_4 = 234235135;
         double number_4_double = number_4;
         
         float number_5 = 12.3f;
         double number_5_double = number_5;
         
         // //Явные преобразования
         
         int number_6 = 234132;
         short number_6_short = (short)number_6;
         
         float number_7 = 2131.35325423f;
         int number_7_integer = (int)number_7;
         
         double number_8 = 345.235345523562356235;
         float number_8_floating_point = (float)number_8;
         
         short number_9 = 12441;
         byte number_9_byte = (byte)number_9;
         
         double number_10 = 23124.24542345;
         short number_10_short = (short)number_10;
         
         // //Упаковка и распаковка значимых типов
         
         int firstVariable = 0;
         object firstObject = firstVariable;
         int firstVariableForUnboxing = (int)firstObject;
         
         long secondVariable = 1;
         object secondObject = secondVariable;
         long secondVariableForUnboxing = (long)secondObject;
         
         float thirdVariable = 1.1f;
         object thirdObject = thirdVariable;
         float thirdVariableForUnboxing = (float)thirdObject;
         
         // //Неявно типизированная переменная
         
         var implicitlyTyped = 124;
         Console.WriteLine("Your implicitly typed variable: " + implicitlyTyped);
         //implicitlyTyped = 214.215;
         
         //Nullable переменная
         
         int? nullableVariable = null;
         Console.WriteLine("\nYour nullable variable is holding " + nullableVariable);
         nullableVariable = 123;
         Console.WriteLine("\nNow its holding " + nullableVariable);
        
        //Объявите строковые литералы. Сравните их

        string str1 = "Kirill";
        string str2 = "Gvozdovskiy";
        int result = String.Compare(str1, str2);

        if (result < 0)
        {
            Console.WriteLine("\nstr1 is greater than str2");
        }
        else if (result > 0)
        {
            Console.WriteLine("\nstr2 is greater than str1");
        }
        else
        {
            Console.WriteLine("\nString are the same");
        }
        
        string firstString = "First string ";
        string secondString = "Second string ";
        string thirdString = "Third string";
        string stringForConcat = String.Concat(firstString, secondString, thirdString);
        Console.WriteLine("\nConnected strings: " + stringForConcat);
        
        string stringForCopy = String.Copy(firstString);
        Console.WriteLine("\nCopied first string: " + stringForCopy);
        
        string stringForSubString = firstString.Substring(0, firstString.Length - 5);
        Console.WriteLine("\nSubstring from first string: " + stringForSubString);
        
        string[] words = thirdString.Split(' ');
        foreach (var word in words)
        {
            Console.WriteLine($"{word}");
        }
        
        string stringForPaste = firstString.Insert(2, stringForSubString);
        Console.WriteLine("\nFirst string with inserted substring from the 2nd position: " + stringForPaste);
        Console.WriteLine("\nFirst string with deleted substring from 2nd position to 7th: " + stringForPaste.Remove(2, 5));
        Console.WriteLine($"\nInterpolation of strings: {firstString}, {secondString}, {thirdString}");
        
        //Пустая и null строка

        string emptyString= "";
        string nullString = null;
        Console.WriteLine("Result of method IsNullOrEmpty for emptyString: "+ String.IsNullOrEmpty(emptyString));
        Console.WriteLine("Result of method IsNullOrEmpty for nullString: "+ String.IsNullOrEmpty(nullString));
        Console.WriteLine("We can unite them: " + emptyString + nullString);
        Console.WriteLine("We can compare them with method Compare: " + String.Compare(emptyString, nullString));
        
        //Создайте строку на основе StringBuilder

        StringBuilder newString = new StringBuilder("String made up by StringBuilder", 50);
        newString.Remove(0, 6);
        newString.Append("A");
        newString.Insert(0, "B");
        Console.WriteLine("\n" + newString);
        
        //Создайте целый двумерный массив и выведите его на консоль в отформатированном виде (матрица)

        int[,] matrix = new int[3, 4] { { 123, 1441, 1244, 233}, {23213, 123, 124, 124}, {2314, 124, 14, 1}};
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }
            Console.WriteLine();
        }
        
        string[] stringArray = new[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.WriteLine("The length of your array is " + stringArray.Length);
        Console.WriteLine("Enter which element you want to replace: ");
        int index = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter your string: ");
        stringArray[index] = Console.ReadLine();
        for (int i = 0; i < stringArray.Length; i++)
        {
            Console.Write(stringArray[i] + " ");
        }
        Console.WriteLine();
        
        double[][] stair_array = new double[3][];
        stair_array[0] = new double[2];
        stair_array[1] = new double[3];
        stair_array[2] = new double[4];
        for (int i = 0; i < 2; i++)
        {
            stair_array[0][i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < 3; i++)
        {
            stair_array[1][i] = Convert.ToDouble(Console.ReadLine());
        }
        for (int i = 0; i < 4; i++)
        {
            stair_array[2][i] = Convert.ToDouble(Console.ReadLine());
        }
        
        var grungeBands = new[] { "Alice In Chains", "Pearl Jam", "Nirvana", "Soundgarden"};
        var implicitString = "When the lights out, It's less dangerous";
        
        //Кортежи
        
        (int tupleInt, string tupleString, char tupleChar, string tupleString2, ulong tupleUlong) tuple = (-2, "Kriss Novoselic", 'K', "Dave Growl", 1244556546);
        Console.WriteLine(tuple);
        Console.WriteLine($"Element 1: {tuple.Item1}, Element3: {tuple.Item3}, Element5: {tuple.Item5}");
        int tmpIntVariable = tuple.tupleInt;
        string tmpStringVariable = tuple.tupleString;
        Console.WriteLine("We are using variable from unpacked tuple: " + tmpStringVariable);
        (int tupleInt, string tupleString, char tupleChar, string tupleString2, ulong tupleUlong) tuple2 = (-2, "Kriss Novoselic", 'K', "Dave Growl", 1244556546);
        if (tuple == tuple2)
        {
            Console.WriteLine("Tuples are the same");
        }
        else
        {
            Console.WriteLine("Tuples are not the same");
        }
        
        //Локальная функция

        (int maxValue, int minValue, int sumOfElements, char firstSymbol) LocalFunction(int[] arrayForFunction,
            string stringForFunction)
        {
            int sum = 0;
            int max = Int32.MinValue;
            int min = Int32.MaxValue;
            for (int i = 0; i < arrayForFunction.Length; i++)
            {
                sum += arrayForFunction[i];
                if (arrayForFunction[i] < min)
                {
                    min = arrayForFunction[i];
                }

                if (arrayForFunction[i] > max)
                {
                    max = arrayForFunction[i];
                }
            }

            return (max, min, sum, stringForFunction[0]);
        };

        Console.WriteLine(LocalFunction(new[] { 1244, 124, -1244, 2144 }, "Kirill"));
        
        //Checked и unchecked
        
         checkedFunction();
         uncheckedFunction();
    }
}