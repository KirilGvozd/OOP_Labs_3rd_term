using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Work2
{
    public static class ControlWork
    {
        public static void Main()
        {
            string[] strings = { "Один", "Два", "Три", "Четыре" };
            var query = strings.Count(length => length.Length == 3);
            Console.WriteLine($"Кол-во строк с длиной 3: {query}");
            SuperStack<int> firstStack = new SuperStack<int>();
            SuperStack<int> secondStack = new SuperStack<int>();
            firstStack.Push(1);
            firstStack.Push(2);
            secondStack.Push(1);
            if(firstStack != secondStack)
            {
                Console.WriteLine("Стеки не равны.");
            }
            else
            {
                Console.WriteLine("Стеки равны.");
            }

            User user = new User();
            Telephone telephone = new Telephone();

        }
        public static void Phone()
        {
            Console.WriteLine("Снял трубку.");
        }
    }
}
