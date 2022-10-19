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

        public Library(string nameOfTheBook, int yearOfPublication, double priceOfBook)
        {
                ListOfAllBooks = new List<PrintPublication>();
                this.NameOfTheBook = nameOfTheBook;
                this.PriceOfBook = priceOfBook;
                this.yearOfPublication = yearOfPublication;
        }

        public void AddItem(PrintPublication item)
        {
                ListOfAllBooks.Add(item);
                
        }
}