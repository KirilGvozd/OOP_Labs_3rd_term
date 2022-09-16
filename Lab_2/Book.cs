using System.Threading.Channels;

namespace Book
{
    public class Book
    {
        private readonly int id;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                Id = value;
            }
        }

        private string name;

        private string authors;
        private string published;
        private int year;
        private int pages;
        private float price;
        private const string binding = "Hard Cover";
        

        
        //Статический конструктор
        static Book()
        {
            Console.WriteLine("Static constructor was called");
        }


        //Конструктор без параметров
        Book()
        {
            Console.WriteLine("Constructor was called");
        }

        //Конструктор со всеми параметрами
        Book(int id, string name, string authors, string published, int year, int pages, float price)
        {
            this.id = id;
            this.name = name;
            this.authors = authors;
            this.published = published;
            this.year = year;
            this.pages = pages;
            this.price = price;
        }

        //Конструктор с параметрами по умолчанию
        Book(int id, string published, int year,
            int pages, float price, string name = "Анна Каренина", string authors = "Лев Толстой")
        {
            this.id = id;
            this.name = name;
            this.authors = authors;
            this.published = published;
            this.year = year;
            this.pages = pages;
            this.price = price;

        }
        
        //Закрытый конструктор

        private Book(int id)
        {
            Console.WriteLine("Closed constructor was called");
        }

        
        public static void Main(string[] args)
        {
            //Вызовы конструкторов
            Book staticBook = new Book();
            
            Book warAndPiece = new Book(1, "War And Peace", "Tolstoy", "Асвета", 2004, 1200, 30.25f);
            Console.WriteLine("The price of " + warAndPiece.name + " is " + warAndPiece.price + " rubles");

            Book annaCarenina = new Book(2, "Асвета", 2003, 400, 15.5f);
            Console.WriteLine("The price of " + annaCarenina.name + " is " + annaCarenina.price + " rubles");
            
            
        }
    }
}