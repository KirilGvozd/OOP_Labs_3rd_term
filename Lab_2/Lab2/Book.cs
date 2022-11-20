namespace Lab2
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
        }

        private string name;
        public string Name
        {
            get
            {
                return name; 
                
            }
            set
            {
                name = value;
            }
        }

        private string author;

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        
        private const string publishingHouse = "Asveta";
        
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        
        private int pages;
        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                pages = value;
            }
        }
        
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        
        private string bindingType;
        public string BindingType
        {
            get
            {
                return bindingType;
            }
            set
            {
                bindingType = value;
            }
        }

        private static int counter = 0;

        Book(int Id, string Name, string Author, int Year, int Pages, double Price, string BindingType)
        {
            this.id = Id;
            this.name = Name;
            this.author = Author;
            this.year = Year;
            this.pages = Pages;
            this.price = Price;
            this.bindingType = BindingType;
            counter++;
        }

        public Book()
        {
            Console.WriteLine("Constructor without parameters was called.\n");
            counter++;
        }

        Book(int Id, string Name, string Author, int Pages, double Price = 15.2, string BindingType = "Plastic")
        {
            this.id = Id;
            this.name = Name;
            this.author = Author;
            this.pages = Pages;
            this.price = Price;
            this.bindingType = BindingType;
            counter++;
        }

        static Book()
        {
            Console.WriteLine("Static constructor was called.\n");
            counter++;
        }

        private Book(int Pages = 1000)
        {
            this.pages = Pages;
            Console.WriteLine("Private constructor was called.\n");
            counter++;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Book book = obj as Book;
            return book.id == this.id;
        }

        public override int GetHashCode()
        {
            return (int)((this.price * this.pages) / this.year);
        }

        public override string ToString()
        {
            return $"Id of the book: {this.id}.\n" +
                   $"Name of the book: {this.name}.\n" +
                   $"Author of this book: {this.author}.\n" +
                   $"Year when this book was published: {this.year}.\n" +
                   $"Amount of pages in this book: {this.pages}.\n" +
                   $"Price of this book: {this.price}.\n" +
                   $"The type of binding in this book: {this.bindingType}.\n";        
        }

        public static void Main()
        {
            Book object1 = new Book(1, "War and Peace", "Leo Tolstoy", 1905, 1500, 30, "Wire");
            Book object2 = new Book();
            Book object3 = new Book(2, "Anna Carenina", "Leo Tolstoy", 500);
            Book objectPrivateConstructor = new Book(1000);

            Console.WriteLine("The name of the first book is " + object1.name + ".\n");
            Console.WriteLine("The price of the second book is " + object3.price + ".\n");
            
            int a = 1;
            Console.WriteLine("Before the method with ref-parameter was called: " + a);
            BookPartial.MethodForIncreasing(ref a);
            Console.WriteLine("After the method with ref-parameter was called: " + a);
            a = 1;
            Console.WriteLine("Before the method with out-parameter was called: " + a);
            BookPartial.MethodForIncreasingOut(out a);
            Console.WriteLine("After the method with out-parameter was called: " + a + ".\n");

            if (Equals(object1, object2))
            {
                Console.WriteLine("Object1 and object2 are the same." + "\n");
            }
            else
            {
                Console.WriteLine("Object1 and object2 are different" + ".\n");
            }

            Console.WriteLine("The data type of the created object1 is " + object1.GetType() + ".\n");

            Console.WriteLine(object1.ToString());

            Book warAndPeace = new Book(1, "War and Peace", "Leo Tolstoy", 1863, 1500, 32.5, "Plastic");
            Book annCarenina = new Book(2, "Anna Carenina", "Leo Tolstoy",1873, 350, 15.54, "Wire");
            Book crimeAndPunishment = new Book(3, "Crime and Punishment", "Fedor Dostoevskiy", 1866, 400, 10.45, "Wood");
            Book theIdiot = new Book(4, "The Idiot", "Fedor Dostoevskiy", 1869, 200, 15.45, "Wire");

            Book[] arrayOfBooks = new[] { warAndPeace, annCarenina, crimeAndPunishment, theIdiot };

            Console.WriteLine("Every book after 1867: ");
            foreach (var book in arrayOfBooks)
            {
                if (book.year > 1867)
                {
                    Console.WriteLine(book.name);
                }
            }
            Console.WriteLine("Every book by Leo Tolstoy: ");
            foreach (var book in arrayOfBooks)
            {
                if (book.author == "Leo Tolstoy")
                {
                    Console.WriteLine(book.name);
                }
            }


            var gusFring = new { name = "Gustavo", surname = "Sus" };
            Console.WriteLine("\nAnonymous type: Hello, my name is " + gusFring.name + ". But you can call me " + gusFring.surname + ".\n");
            Console.WriteLine("Constructor was called " + counter + " times.");
        }
    }
}