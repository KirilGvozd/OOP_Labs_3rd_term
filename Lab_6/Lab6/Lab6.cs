namespace Lab6;

class Lab6
{
        public static void Main()
        {
                try
                {
                        Book book1 = null;
                }
                catch (PrintPublicationException e)
                {
                        Console.WriteLine(e.Message);
                        Console.WriteLine("You created null object!");
                        
                }
        }
}
