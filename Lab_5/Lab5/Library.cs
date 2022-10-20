namespace Lab5;
using System.Collections.Generic;


public class Library
{
        public List<PrintPublication> ListOfAllBooks { get; private set; }
        public string? NameOfTheBook { get; private set; }
        public int yearOfPublication { get; private set; }
        public double PriceOfBook { get; private set; }
        private double _sumOfAllBooks;
        private int _numberOfWorkBooks;

        public Library() 
        {
                ListOfAllBooks = new List<PrintPublication>();
        }

        public void AddItem(PrintPublication item)
        {
                ListOfAllBooks.Add(item);
                _sumOfAllBooks += item.PriceOfThePrintPublication;
                _numberOfWorkBooks++;
        }

        public void DeleteItem(PrintPublication item)
        {
                ListOfAllBooks.Remove(item);
                _sumOfAllBooks -= item.PriceOfThePrintPublication;
                _numberOfWorkBooks--;
        }

        public void PrintList()
        {
                Console.WriteLine("\nPrinting the list:");
                foreach (var item in ListOfAllBooks)
                {
                        Console.WriteLine(item.ToString());
                }

                Console.WriteLine("\nNumber of all books in library: " + _numberOfWorkBooks);
                Console.WriteLine("Sum of all books in library: " + _sumOfAllBooks);
        }
}