namespace Lab10;
public class Book
    {
        private string NameOfTheBook { get; set; }
        public string Author { get; set; }
        public int YearOfPublishing { get; set; }
        public int AmountOfPages { get; set; }
        public double Price { get; set; }

        public Book()
        {
        }
        public Book(string name, string author, int year, int pages, double price)
        {
            NameOfTheBook = name;
            Author = author;
            YearOfPublishing = year;
            AmountOfPages = pages;
            Price = price;
        }
    }
